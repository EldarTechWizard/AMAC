
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
        private Action<bool> CheckStateId;
        public FormatAnimalPresenter(IFormatAnimalView view, Action<bool> checkStateId)
        {
            this.view = view;
            AssociateAndRaisedEvents();
            this.CheckStateId = checkStateId;
        }

        public FormatAnimalPresenter(IFormatAnimalView view, DataTable data,Action<bool> checkStateId)
        {
            this.view = view;
            this.view.DataSource = data;
            AssociateAndRaisedEvents();
            this.CheckStateId = checkStateId;
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
                DataRow row = view.OpenSearchTableTab(view.DataSource);
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
                DataRow row = view.DataSource.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAnimal") == (int)view.Id);

                if (row == null)
                {
                    view.ClearAnimalFields();
                    CheckStateId(false);
                    return;
                }

                LoadAnimalFields(row);
                CheckStateId(true);
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
