
using AMAC.Views.FormatManagement.FormatControls.FormatAdopterView;
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
    public class FormatAdopterPresenter
    {
        private IFormatAdopterView view;
        private DataTable adopters;
        public FormatAdopterPresenter(IFormatAdopterView view, DataTable data)
        {
            this.view = view;
            this.adopters = data;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSearchAdopterPictureEdit += OnClickSearchAdopterPictureEdit;
            view.OnChangeAdopterIdTextBox += OnChangeAdopterIdTextBox;
        }

        private void OnChangeAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataRow row = adopters.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAdopter") == (int)view.Id);

                if (row == null)
                {
                    view.ClearAdopterFields();
                    return;
                }
              
                LoadAdopterFields(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAdopterFields(DataRow row)
        {
            view.NameA = (string)row["name"];
            view.Age = (int)row["age"];
            view.Email = (string)row["email"];
            view.Address = (string)row["address"];
            view.Number = (string)row["phone"];
        }
        private void OnClickSearchAdopterPictureEdit(object sender, EventArgs e)
        {
            try
            {
                DataRow row = view.OpenSearchTableTab(adopters);
                if (row == null) return;

                view.Id = (int)row["idAdopter"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
