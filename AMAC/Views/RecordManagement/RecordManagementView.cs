using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.RecordManagement
{
    public partial class RecordManagementView : DevExpress.XtraEditors.XtraForm, IRecordManagementView
    {
        public DataTable DataSource { get => (DataTable)dgvData.DataSource; set => dgvData.DataSource = value; }
        public string SelectedColumn => cbColumns.Text;
        public string FilterText => tbFilterText.Text;

        public event EventHandler OnLoadForm;
        public event EventHandler OnChangeFilterTextTextBox;

        public RecordManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();

        }             
        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            tbFilterText.TextChanged += delegate { OnChangeFilterTextTextBox.Invoke(tbFilterText, EventArgs.Empty); };
        }
             
    }
}