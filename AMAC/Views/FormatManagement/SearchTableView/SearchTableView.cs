using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.SearchTableView
{
    public partial class SearchTableView : DevExpress.XtraEditors.XtraForm, ISearchTableView
    {
        private DataRow dataRow;
        public string FilterText => tbFilterText.Text;
        public DataTable DataSource { get => (DataTable)dgvData.DataSource; set => dgvData.DataSource = value; }
        public DataRow DataRow { get => dataRow; set => dataRow = value; }
        public List<string> DataSourceCb { set => cbColumns.Properties.DataSource = value; }
        public string SelectedColumn => cbColumns.Text;

        public event EventHandler OnClickCloseButton;
        public event EventHandler OnChangeFilterTextTextBox;
        public event EventHandler OnClickSelectRowGridControl;
        public event EventHandler OnLoadForm;

        public SearchTableView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnClose.Click += delegate { OnClickCloseButton.Invoke(btnClose, EventArgs.Empty); };
            tbFilterText.TextChanged += delegate { OnChangeFilterTextTextBox.Invoke(btnClose, EventArgs.Empty); };
            gridView1.DoubleClick += delegate { OnClickSelectRowGridControl.Invoke(gridView1, EventArgs.Empty); };
        }

        public void SetDataRow()
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                dataRow = gridView1.GetDataRow(i);
            }
        }

        public void CloseTab()
        {
            this.Close();
        }

        public void SetCbColumnsPropierties()
        {/*
            cbColumns.Properties.ValueMember = "Item1";
            cbColumns.Properties.DisplayMember = "Item1";*/
        }
    }
}