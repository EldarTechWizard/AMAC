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

namespace AMAC.Views.AnimalManagement
{
    public partial class AnimalManagementView : DevExpress.XtraEditors.XtraForm, IAnimalManagementView
    {
        private string filePath = "";
        private bool editMode = false;

        public event EventHandler OnClickSaveAndEditAnimalButton;
        public event EventHandler OnClickDeleteAnimalButton;
        public event EventHandler OnClickChoosePhotoButton;
        public event EventHandler OnLoadForm;
        public event EventHandler OnChangedAdopterIdTextBox;
        public event EventHandler OnClickSelectRowGridControl;
        public event EventHandler OnClickGenerateInsertButton;

        public AnimalManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();

            cbSex.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            cbAnimalType.SelectedIndex = 0;
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnSaveAndEdit.Click += delegate { OnClickSaveAndEditAnimalButton.Invoke(btnSaveAndEdit, EventArgs.Empty); };
            btnDelete.Click += delegate { OnClickDeleteAnimalButton.Invoke(btnDelete, EventArgs.Empty); };           
            btnChoosePhoto.Click += delegate { OnClickChoosePhotoButton.Invoke(btnChoosePhoto, EventArgs.Empty); };
            btnGenerateInsert.Click += delegate { OnClickGenerateInsertButton.Invoke(btnGenerateInsert, EventArgs.Empty); };
            gridView1.Click += delegate { OnClickSelectRowGridControl.Invoke(gridView1, EventArgs.Empty); };
            tbId.TextChanged += delegate { OnChangedAdopterIdTextBox.Invoke(tbId, EventArgs.Empty); };
        }

        public DataTable DataSource { get => (DataTable)dgvAnimal.DataSource; set => dgvAnimal.DataSource = value; }
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
        public string PicturePath {
            get => filePath; 
            set { 
                filePath = value;
                if(value != null && value != "") peImage.Image = Image.FromFile(value); 
            } 
        }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
        public string AnimalBreed { get => tbAnimalBreed.Text; set => tbAnimalBreed.Text = value; }
        public int Age { get => int.Parse(tbAge.Text); set => tbAge.Text = value.ToString(); }
        public string Sex { get => cbSex.Text; set => cbSex.Text = value; }
        public bool Sterilized { get => chbSterilized.Checked; set => chbSterilized.Checked = value; }
        public string AnimalType { get => cbAnimalType.Text; set => cbAnimalType.Text = value; }
        public string AdditionalInformation { get => tbAdditionalInformation.Text; set => tbAdditionalInformation.Text = value; }
        public string Status { get => cbStatus.Text; set => cbStatus.Text = value; }
        public DateTime RescuedDate { get => dtFecha.Value; set => dtFecha.Value = value; }
        public string TemporaryHome { get => tbTempHome.Text; set => tbTempHome.Text = value; }
        public string Rescuer { get => tbRescuer.Text; set => tbRescuer.Text = value; }
        public string Veterinarian { get => tbVet.Text; set => tbVet.Text = value; }
        public string Diagnostic { get => tbDiagnostic.Text; set => tbDiagnostic.Text = value; }
        public bool EditMode { get => editMode; set => editMode = value; }

        public void ChangeEditMode(bool aux)
        {
            if (aux)
            {
                btnSaveAndEdit.Text = "EDITAR";
                btnDelete.Enabled = true;
                editMode = true;
            }
            else
            {
                btnSaveAndEdit.Text = "GUARDAR";
                btnDelete.Enabled = false;
                editMode = false;
            }
        }

        public void ClearFields()
        {
            tbName.Text = "";
            tbAge.Text = "";
            cbStatus.Text = "Sano";
            cbSex.Text = "";
            cbAnimalType.Text = "";
            tbAnimalBreed.Text = "";
            tbAdditionalInformation.Text = "";
            tbDiagnostic.Text = "";
            tbRescuer.Text = "";
            tbTempHome.Text = "";
            tbVet.Text = "";
            chbSterilized.Checked = false;
            dtFecha.Value = DateTime.Now;
            peImage.Image = null;

            
        }

        public void LoadInfoFromSelectedRow()
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                this.Id = (int)row["id"];              
            }
        }

        public void ChooseImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg";
            openFileDialog.FileName = "";
            openFileDialog.Title = "Titulo del Dialogo";
            openFileDialog.InitialDirectory = "C:\\"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {     
                this.PicturePath = openFileDialog.FileName;
            }
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void SetDisplayNumbers(int adopted, int temphHome, int deceased)
        {
            lblCountAdop.Text = adopted.ToString();
            lblCountFalle.Text = deceased.ToString();
            lblCountHogar.Text = temphHome.ToString();
        }
    }
}