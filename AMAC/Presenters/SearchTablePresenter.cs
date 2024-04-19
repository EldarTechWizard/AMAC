
using AMAC.Views.FormatManagement.SearchTableView;
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
    public class SearchTablePresenter
    {
        private ISearchTableView view;
        private DataTable data;
        public SearchTablePresenter(ISearchTableView view, DataTable data)
        {
            this.view = view;
            this.data = data;
            this.view.DataSource = data;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnClickCloseButton += OnClickCloseButton;
            view.OnClickSelectRowGridControl += OnClickSelectRowGridControl;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {

        }
      
        private void OnClickSelectRowGridControl(object sender, EventArgs e)
        {
            try
            {
                view.SetDataRow();
                view.CloseTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickCloseButton(object sender, EventArgs e)
        {
            try
            {
                view.CloseTab();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
