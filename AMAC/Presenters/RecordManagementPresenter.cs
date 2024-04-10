using AMAC.Views.AdopterManagement;
using AMAC.Views.RecordManagement;
using DbManagmentAMAC.Models;
using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class RecordManagementPresenter
    {
        private IRecordManagementView view;
        private IRepository repository;
        private DataTable data = new DataTable();

        public RecordManagementPresenter(IRecordManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnChangeFilterTextTextBox += OnChangeFilterTextTextBox;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                if (!repository.SelectRecord(data)) throw new Exception(repository.LastError);
                this.data = data;
                view.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnChangeFilterTextTextBox(object sender, EventArgs e)
        {
            try
            {
                if (view.DataSource.Rows.Count == 0 || view.SelectedColumn == "") return;
                view.DataSource = this.data.AsEnumerable().Where(row => row.Field<string>(view.SelectedColumn).StartsWith(view.FilterText)).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
