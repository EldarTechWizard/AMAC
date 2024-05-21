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
        private int adoptionCount = 0;

        public event EventHandler OnClickSaveAndEditButton;
        public event EventHandler OnClickDeleteButton;
        public event EventHandler OnLoadForm;
        public event EventHandler OnClickSelectRowGridControl;
        public event EventHandler OnChangedAdopterIdTextBox;
        public event EventHandler OnClickGenerateInsertButton;

        public AdopterManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnSaveAndEdit.Click += delegate { OnClickSaveAndEditButton.Invoke(btnSaveAndEdit, EventArgs.Empty); };
            btnGenerateInsert.Click += delegate { OnClickGenerateInsertButton.Invoke(btnGenerateInsert, EventArgs.Empty); };
            btnDelete.Click += delegate { OnClickDeleteButton.Invoke(btnDelete, EventArgs.Empty); };
            tbId.TextChanged += delegate { OnChangedAdopterIdTextBox.Invoke(tbId, EventArgs.Empty); };
            gridView1.Click += delegate { OnClickSelectRowGridControl.Invoke(gridView1, EventArgs.Empty); };
        }
        public DataTable DataSource { get => (DataTable)dgvAdopter.DataSource; set => dgvAdopter.DataSource = value; }
        public bool EditMode { get => editMode; set => editMode = true; }
        public int Id 
        {
            get 
            {
                int value = 0;

                if (int.TryParse(tbId.Text, out value))
                {
                    return value;
                }

                return -1;
            }
            
            set => tbId.Text = value.ToString(); 
        }
        public int Age 
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbAge.Text, out value))
                {
                    return value;
                }

                return -1;
            }

            set => tbAge.Text = value.ToString();
        }
        public string Address { get => tbAddress.Text; set => tbAddress.Text = value; }
        public string Number { get => tbNumber.Text; set => tbNumber.Text = value; }
        public string Email { get => tbEmail.Text; set => tbEmail.Text = value; }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
        public int AdoptionCount { get => adoptionCount; set => adoptionCount = value; }

        public void ChangeEditMode(bool aux)
        {
            ChangeDeleteMode(aux);

            if (aux)
            {
                btnSaveAndEdit.Text = "GUARDAR CAMBIOS";
                editMode = true;
                return;
            }

            btnSaveAndEdit.Text = "GUARDAR";
            editMode = false;
            
        }

        public void ClearFields()
        {
            tbName.Text = "";
            tbAge.Text = "";
            tbAddress.Text = "";
            tbNumber.Text = "";
            tbEmail.Text = "";
        }

        public void LoadInfoFromSelectedRow()
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                this.Id = int.Parse(row["idAdopter"].ToString());   
            }
            ChangeDeleteMode(true);
        }

        public void ChangeDeleteMode(bool aux)
        {
            btnDelete.Enabled = aux;           
        }
    }
        
}