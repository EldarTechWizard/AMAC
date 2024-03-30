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
        public string FilterText => tbFilterText.Text;
        public DataTable DataSource { get => (DataTable)dgvData.DataSource; set => dgvData.DataSource = value; }

        public event EventHandler OnClickCloseButton;
        public event EventHandler OnChangeFilterTextTextBox;
        public SearchTableView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnClose.Click += delegate { OnClickCloseButton.Invoke(btnClose, EventArgs.Empty); };
            tbFilterText.TextChanged += delegate { OnChangeFilterTextTextBox.Invoke(btnClose, EventArgs.Empty); };
        }
        public void CloseTab()
        {
            this.Close();
        }
    }
}