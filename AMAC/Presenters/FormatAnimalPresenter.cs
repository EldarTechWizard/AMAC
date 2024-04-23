
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
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
    public class FormatAnimalPresenter
    {
        private IFormatAnimalView view;
        private DataTable animals;
        public FormatAnimalPresenter(IFormatAnimalView view, DataTable animals)
        {
            this.view = view;
            this.animals = animals;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnChangeAnimalIdTextBox += OnChangeAdopterIdTextBox;
            view.OnClickSearchAnimalPictureEdit += OnClickSearchAdopterPictureEdit;
        }

        private void OnClickSearchAdopterPictureEdit(object sender, EventArgs e)
        {
            try
            {
                DataRow row = view.OpenSearchTableTab(animals);
                if (row == null) return;

                view.Id = (int)row["idAnimal"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnChangeAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataRow row = animals.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAnimal") == (int)view.Id);

                if (row == null)
                {
                    view.ClearAnimalFields();
                    return;
                }

                LoadAnimalFields(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAnimalFields(DataRow row)
        {
            view.NameA = (string)row["name"];
            view.Age = (int)row["age"];
            view.Sex = (string)row["sex"];
            view.AnimalBreed = (string)row["breed"];
            view.AnimalType = (string)row["animalType"];
            view.Sterilized = (bool)row["sterilized"];
            view.Status = (string)row["status"];
            view.AdditionalInformation = (string)row["additionalInformation"];
        }


    }
}
