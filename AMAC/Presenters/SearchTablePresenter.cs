
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
            view.OnChangeFilterTextTextBox += OnChangeFilterTextTextBox;
            view.OnClickSelectRowGridControl += OnClickSelectRowGridControl;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                view.DataSourceCb = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void OnChangeFilterTextTextBox(object sender, EventArgs e)
        {
            try
            {
                if (data.Rows.Count == 0 || view.SelectedColumn == "") return;
                this.view.DataSource = this.data.AsEnumerable().Where(row => row.Field<string>(view.SelectedColumn).StartsWith(view.FilterText)).CopyToDataTable();
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
