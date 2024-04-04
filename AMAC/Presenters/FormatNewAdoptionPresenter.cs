using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
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

        private DataTable AnimalData;
        private DataTable AdopterData;
        public FormatNewAdoptionPresenter(IFormatNewAdoptionView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnChangeAnimalIdTextBox += OnChangeAnimalIdTextBox;
            view.OnChangeAdopterIdTextBox += OnChangeAdopterIdTextBox;
            view.OnClickGenerateNewAdoptionFormatButton += OnClickGenerateNewAdoptionFormatButton;
            view.OnClickClearFieldsButton += OnClickClearFieldsButton;
            view.OnClickSearchAnimalPictureEdit += OnClickSearchAnimalPictureEdit;
            view.OnClickSearchAdopterPictureEdit += OnClickSearchAdopterPictureEdit;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                LoadAnimalInfo();
                LoadAdopterInfo();
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

        private void OnClickClearFieldsButton(object sender, EventArgs e)
        {
            try
            {
                view.ClearFields();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickGenerateNewAdoptionFormatButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnChangeAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
  
                DataRow row = AnimalData.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAdopter") == (int)view.AnimalId);

                if (row != null)
                {
                    view.AdopterNamA = (string)row["name"];
                    view.AdopterAge = (int)row["age"];
                    view.AdopterEmail = (string)row["email"];
                    view.AdopterAddress = (string)row["address"];
                    view.AdopterNumber = (string)row["phone"];

                    return;
                }

                view.ClearAdopterFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnChangeAnimalIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataRow row = AnimalData.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAnimal") == (int)view.Id);

                if (row != null)
                {
                    view.AnimalName = (string)row["name"];
                    view.AnimalAge = (int)row["age"];
                    view.AnimalAge = (int)row["age"];
                    view.AnimalSex = (string)row["sex"];
                    view.AnimalBreed = (string)row["breed"];
                    view.AnimalType = (string)row["animalType"];
                    view.AnimalStatus = (string)row["status"];
                    view.AnimalAdditionalInformation = (string)row["additionalInformation"];

                    return;
                }

                view.ClearAnimalFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickSearchAdopterPictureEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSearchAnimalPictureEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
