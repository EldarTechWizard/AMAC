using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement.FormatControls.FormatAdopterView;
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
using AMAC.Views.FormatManagement.FormatControls.FormatVolunterView;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatUpdateView;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class FormatNewAdoptionPresenter
    {
        private IFormatNewAdoptionView view;
        private IRepository repository;

        private DataTable AnimalData = new DataTable();
        private DataTable AdopterData = new DataTable();

        private PdfFormat temp = null;
        public FormatNewAdoptionPresenter(IFormatNewAdoptionView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnClickGenerateNewAdoptionFormatButton += OnClickGenerateNewAdoptionFormatButton;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                LoadAnimalInfo();
                LoadAdopterInfo();
                view.LoadTabs(ref AnimalData, ref AdopterData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAnimalInfo()
        {
            if (!repository.SelectRecord(AnimalData)) throw new Exception(repository.LastError);
        }

        private void LoadAdopterInfo()
        {
            if (!repository.SelectAdopter(AdopterData)) throw new Exception(repository.LastError);
        }

      
        private void OnClickGenerateNewAdoptionFormatButton(object sender, EventArgs e)
        {
            try
            {
                PdfGenerator generator = GetGeneratorWithAtributtes();
                if(!view.OpenPreviewTab(generator)) return;

                view.SavePdf();
                InsertFormatIntoDataBase();
                MessageBox.Show("Correcto");
                temp = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private PdfGenerator GetGeneratorWithAtributtes()
        {
            Animal animal = ((IFormatAnimalView)view.AnimalForm).GetAnimal();

            Adopter adopter = ((IFormatAdopterView)view.AdopterForm).GetAdopter();

            temp = new PdfFormat()
            {
                AnimalId = animal.Id,
                AdopterId = adopter.Id,
                AdoptionDate = ((IFormatVolunterView)view.ResponsabilityForm).Date,
                Volunter = ((IFormatVolunterView)view.ResponsabilityForm).Volunter,
            };

            return new PdfGenerator(animal, adopter, temp);
        }

        private void InsertFormatIntoDataBase()
        {
            if (!repository.InsertPdfFormat(temp)) throw new Exception(repository.LastError);
        }

  
    }
}
