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
        private bool editMode = false;

        public event EventHandler OnClickSaveAndEditAnimalButton;
        public event EventHandler OnClickDeleteAnimalButton;
        public event EventHandler OnClickSearchPictureEdit;
        public event EventHandler OnClickChoosePhotoButton;
        public event EventHandler OnLoadForm;

        public AnimalManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnSaveAndEdit.Click += delegate { OnClickSaveAndEditAnimalButton.Invoke(btnSaveAndEdit, EventArgs.Empty); };
            btnDelete.Click += delegate { OnClickDeleteAnimalButton.Invoke(btnDelete, EventArgs.Empty); };
            peSearch.Click += delegate { OnClickSearchPictureEdit.Invoke(peSearch, EventArgs.Empty); };
            btnChoosePhoto.Click += delegate { OnClickChoosePhotoButton.Invoke(btnChoosePhoto, EventArgs.Empty); };
           
        }

        public DataTable DataSource { get => (DataTable)dgvAnimal.DataSource; set => dgvAnimal.DataSource = value; }

        public string PicturePath => peImage.GetLoadedImageLocation() as string;

        public string AnimalBreed => tbAnimalBreed.Text;

        public int Age => int.Parse(tbAge.Text);

        public string Sex => cbSexo.Text;

        public bool Sterilized => chbSterilized.Checked;

        public string AnimalType => tbAnimalType.Text;

        public string AdditionalInformation => tbAdditionalInformation.Text;

        public bool EditMode => editMode;

        public string NameA => tbName.Text;

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