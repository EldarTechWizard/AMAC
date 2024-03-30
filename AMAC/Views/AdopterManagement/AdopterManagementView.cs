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

namespace AMAC.Views.AdopterManagement
{
    public partial class AdopterManagementView : DevExpress.XtraEditors.XtraForm, IAdopterManagementView
    {
        private bool editMode = false;

        public event EventHandler OnClickSaveAndEditButton;
        public event EventHandler OnClickDeleteButton;
        public event EventHandler OnClickSearchPictureEdit;
        public event EventHandler OnLoadForm;
        public AdopterManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnSaveAndEdit.Click += delegate { OnClickSaveAndEditButton.Invoke(btnSaveAndEdit, EventArgs.Empty); };
            btnDelete.Click += delegate { OnClickDeleteButton.Invoke(btnDelete, EventArgs.Empty); };
            peSearch.Click += delegate { OnClickSearchPictureEdit.Invoke(peSearch, EventArgs.Empty); };
        }
        public DataTable DataSource { get => (DataTable)dgvAdopter.DataSource; set => dgvAdopter.DataSource = value; }

        public bool EditMode => editMode;

        public string Age => tbAge.Text;

        public string Address => tbAddress.Text;

        public string Number => tbNumber.Text;

        public string Email => tbEmail.Text;

        

        

        public void ChangeEditMode()
        {
            throw new NotImplementedException();
        }

        public void ClearFields()
        {
            throw new NotImplementedException();
        }
    }
        
}