﻿using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement;
using AMAC.Views.FormatManagement.FormatControls.FormatAdopterView;
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
using AMAC.Views.FormatManagement.FormatControls.FormatVolunterView;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatUpdateView;
using DbManagmentAMAC.Models;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMAC.Presenters
{
    public class FormatUpdatePresenter
    {

        private IFormatUpdateView view;
        private IRepository repository;

        private DataTable animalData = new DataTable();
        private DataTable adopterData = new DataTable();

        private bool[] idStates = new bool[3];

        public FormatUpdatePresenter(IFormatUpdateView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnClickTabButtons += OnClickTabButtons;
            view.OnClickSaveButton += OnClickSaveButton;
            view.OnChangeFormatIdLookUpEdit += OnChangeFormatIdLookUpEdit;
            view.OnClickDeleteButton += OnClickDeleteButton;
        }

        private void OnClickDeleteButton(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No) return;
                if (!repository.DeletePdfFormat(view.Id)) throw new Exception(repository.LastError);
                view.CloseCurrentTab();   
                LoadFormatData();

                view.ChangeDeleteButtonMode(false);
                idStates[0] = false; idStates[1] = false; idStates[2] = false;
                CheckChanges();

                view.ChangeTabsButtonMode(false);

                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private PdfGenerator GetGeneratorWithAtributtes()
        {
            DataRow animalRow = animalData.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAnimal") == (int)view.AnimalId);
            DataRow adopterRow = adopterData.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAdopter") == (int)view.AdopterId);


            if (animalRow == null || adopterRow == null) return null;

            Animal animal = new Animal()
            {
                Id = view.AnimalId,
                Name = (string)animalRow["name"],
                Age = (int)animalRow["age"],
                Sex = (string)animalRow["sex"],
                AnimalType = (string)animalRow["animalType"],
                AnimalBreed = (string)animalRow["breed"],
                Sterilized = (bool)animalRow["sterilized"],
                AdditionalInformation = (string)animalRow["additionalInformation"],
                Status = (string)animalRow["status"],
            };

            Adopter adopter = new Adopter()
            {
                Id = view.AdopterId,
                Name = (string)adopterRow["name"],
                Address = (string)adopterRow["address"],
                Age = (int)adopterRow["age"],
                Email = (string)adopterRow["email"],
                Number = (string)adopterRow["phone"],
            };

            PdfFormat pdfFormat = new PdfFormat()
            {
                AnimalId = view.AnimalId,
                AdopterId = view.AdopterId,
                AdoptionDate = view.AdoptionDate,
                Volunter = view.Volunter
            };

            return new PdfGenerator(animal, adopter, pdfFormat);
        }

        private void OnChangeFormatIdLookUpEdit(object sender, EventArgs e)
        {
            try
            {
                LoadActualDataInView();
                SetDataInsideTab();
                view.ChangeDeleteButtonMode(true);
                view.ChangeTabsButtonMode(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadActualDataInView()
        {
            DataRowView row = view.CurrentData;

            view.Id = (int)row["idAdoptionForm"];
            view.AdopterId = (int)row["idAdopter"];
            view.AnimalId = (int)row["idAnimal"];
            view.Volunter = (string)row["volunteer"];
            view.AdoptionDate = (DateTime)row["adoptionDate"];

            idStates[0] = true; idStates[1] = true; idStates[2] = true;

            CheckChanges();
        }

        private void SetDataInsideTab()
        {
            if (view.CurrentTab == null) return;


            switch (view.CurrentTab.Tag)
            {
                case "Animal":
                    
                    ((IFormatAnimalView)view.CurrentTab).Id = view.AnimalId;

                    break;
                case "Adopter":
                    ((IFormatAdopterView)view.CurrentTab).Id = view.AdopterId;

                    break;
                case "Responsability":
   
                    ((IFormatVolunterView)view.CurrentTab).Volunter = view.Volunter;
                    ((IFormatVolunterView)view.CurrentTab).Date = view.AdoptionDate;
                    
                    break;

                default:
                    break;
            }
        }

        private void OnClickSaveButton(object sender, EventArgs e)
        {
            try
            {              
                PdfGenerator generator = GetGeneratorWithAtributtes();

                if (generator == null) return;
                if (!view.OpenPreviewTab(generator)) return;
                view.SavePdf();

                GetDataInsideATab();
                UpdateFormatData();
                LoadFormatData();
                view.CloseCurrentTab();

                MessageBox.Show("Cambios guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateFormatData()
        {
            PdfFormat format = new PdfFormat()
            {
                Id = view.Id,
                AdopterId = view.AdopterId,
                AnimalId = view.AnimalId,
                Volunter = view.Volunter,
                AdoptionDate = view.AdoptionDate
            };

            if (!repository.UpdatePdfFormat(format)) throw new Exception(repository.LastError);
        }
        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                animalData = GetAnimalData();
                adopterData = GetAdopterData();
                LoadFormatData();
                view.SetLookUpEditPropierties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable GetAnimalData()
        {
            DataTable data = new DataTable();
            if (!repository.SelectRecord(data)) throw new Exception(repository.LastError);
            
            return data;
        }

        private DataTable GetAdopterData()
        {
            DataTable data = new DataTable();
            if (!repository.SelectAdopter(data)) throw new Exception(repository.LastError);
            return data;
        }

        private void LoadFormatData()
        {
            DataTable formatData = new DataTable();
            if (!repository.SelectPdfFormat(formatData)) throw new Exception(repository.LastError);
            view.DataSource = formatData;
        }

        private void OnClickTabButtons(object sender, EventArgs e)
        {
            string buttonTag = ((SimpleButton)sender).Tag.ToString();


            Form tab = null;

            switch (buttonTag)
            {
                case "Animal":
                    IFormatAnimalView animalTab = new FormatAnimalView();
                    animalData = animalData.AsEnumerable().Where(row => row.Field<string>("status") != "Adoptado" || row.Field<int>("idAnimal") == view.AnimalId).CopyToDataTable();

                    new FormatAnimalPresenter(animalTab, animalData,(bool aux) => {
                        idStates[0] = aux;
                        CheckChanges();
                    });

                    animalTab.DataSource = GetAnimalData();
                    tab = (Form)animalTab;

                    break;
                case "Adopter":
                    IFormatAdopterView adopterTab = new FormatAdopterView();
                    new FormatAdopterPresenter(adopterTab, adopterData, (bool aux) => {
                        idStates[1] = aux;
                        CheckChanges();
                    });

                    adopterTab.DataSource = GetAdopterData();   
                    tab = (Form)adopterTab;

                    break;
                case "Responsability":
                    
                    IFormatVolunterView responsabilityTab = new FormatVolunterView();
                    new FormatVolunterPresenter(responsabilityTab, (bool aux) => {
                        idStates[2] = aux;
                        CheckChanges();
                    });

                    tab = (Form)responsabilityTab;
                    
                    break;

                default:
                    throw new ArgumentException("Error al cambiar una nueva pestaña");
            }

            tab.Tag = buttonTag;

            GetDataInsideATab();
            view.ChangeTab(tab);
            SetDataInsideTab();
        }

        private void GetDataInsideATab()
        {
            if (view.CurrentTab == null) return;

            switch (view.CurrentTab.Tag)
            {
                case "Animal":

                    int animalId = ((IFormatAnimalView)view.CurrentTab).Id;

                    idStates[0] = animalData.AsEnumerable().Any(row => row.Field<int>("idAnimal") == animalId);

                    view.AnimalId = animalId;

                    break;
                case "Adopter":

                    int adopterId = ((IFormatAdopterView)view.CurrentTab).Id;

                    idStates[1] = adopterData.AsEnumerable().Any(row => row.Field<int>("idAdopter") == adopterId);

                    view.AdopterId = adopterId;

                    break;
                case "Responsability":

                    string volunter = ((IFormatVolunterView)view.CurrentTab).Volunter;

                    idStates[2] = volunter != "";

                    view.Volunter = volunter;
                    view.AdoptionDate = ((IFormatVolunterView)view.CurrentTab).Date;
                    
                    break;

                default:
                    break;
            }
        }

        public void CheckChanges()
        {
            if (idStates[0] && idStates[1] && idStates[2])
            {
                view.ChangeSaveButtonMode(true);
                return;
            }

            view.ChangeSaveButtonMode(false);
        }
    }
}
