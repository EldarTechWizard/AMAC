using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement;
using AMAC.Views.FormatManagement.FormatControls.FormatAdopterView;
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
using AMAC.Views.FormatManagement.FormatControls.FormatVolunterView;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatUpdateView;
using DbManagmentAMAC.Models;
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
            view.OnClickPrintPdfButton += OnClickPrintPdfButton;
            view.OnClickDeleteButton += OnClickDeleteButton;
        }

        private void OnClickDeleteButton(object sender, EventArgs e)
        {
            try
            {
                if (!repository.DeletePdfFormat(view.Id)) throw new Exception(repository.LastError);
                view.CloseCurrentTab();   
                LoadFormatData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickPrintPdfButton(object sender, EventArgs e)
        {
            try
            {
                PdfGenerator generator = GetGeneratorWithAtributtes();

                if (!view.OpenPreviewTab(generator)) return; 

                view.SavePdf();
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
        }

        private void SetDataInsideTab()
        {
            if (view.CurrentTab == null) return;
            DataRowView row = view.CurrentData;


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
                if (view.CurrentTab == null) return;

                GetDataInsideATab();
                UpdateFormatData();
                LoadFormatData();

                MessageBox.Show("Correcto");
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
                LoadAnimalInfo();
                LoadAdopterInfo();
                LoadFormatData();
                view.SetLookUpEditPropierties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAnimalInfo()
        {
            if (!repository.SelectRecord(animalData)) throw new Exception(repository.LastError);
        }

        private void LoadAdopterInfo()
        {
            if (!repository.SelectAdopter(adopterData)) throw new Exception(repository.LastError);
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
                    new FormatAnimalPresenter(animalTab, animalData);
                    tab = (Form)animalTab;

                    break;
                case "Adopter":
                    IFormatAdopterView adopterTab = new FormatAdopterView();
                    new FormatAdopterPresenter(adopterTab, adopterData);
                    tab = (Form)adopterTab;

                    break;
                case "Responsability":
                    
                    IFormatVolunterView responsabilityTab = new FormatVolunterView();
                    new FormatVolunterPresenter(responsabilityTab);
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
            DataRowView row = view.CurrentData;


            switch (view.CurrentTab.Tag)
            {
                case "Animal":

                    view.AnimalId = ((IFormatAnimalView)view.CurrentTab).Id;

                    break;
                case "Adopter":
                    view.AdopterId = ((IFormatAdopterView)view.CurrentTab).Id;

                    break;
                case "Responsability":
                    
                    view.Volunter = ((IFormatVolunterView)view.CurrentTab).Volunter;
                    view.AdoptionDate = ((IFormatVolunterView)view.CurrentTab).Date;
                    
                    break;

                default:
                    break;
            }
        }
    }
}
