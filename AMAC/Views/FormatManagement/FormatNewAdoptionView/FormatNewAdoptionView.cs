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

namespace AMAC.Views.FormatManagement.FormatNewAdoptionView
{
    public partial class FormatNewAdoptionView : DevExpress.XtraEditors.XtraForm, IFormatNewAdoptionView
    {
        public int AnimalId 
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbAnimalId.Text, out value))
                {
                    return value;
                }

                return -1;
            }

            set => tbAnimalId.Text = value.ToString();
        }
        public string AnimalName { get => tbAnimalId.Text; set => tbAnimalId.Text = value; }
        public string AnimalBreed { get => tbAnimalBreed.Text; set => tbAnimalBreed.Text = value; }
        public int AnimalAge { get => int.Parse(tbAnimalAge.Text); set => tbAnimalAge.Text = value.ToString(); }
        public string AnimalSex { get => tbAnimalSex.Text; set => tbAnimalSex.Text = value; }
        public bool AnimalSterilized { get => chbSterilized.Checked; set => chbSterilized.Checked = value; }
        public string AnimalType { get => tbAnimalType.Text; set => tbAnimalType.Text = value; }
        public string AnimalAdditionalInformation { get => tbAnimalAdditionalInformation.Text; set => tbAnimalAdditionalInformation.Text = value; }
        public string AnimalStatus { get => tbAnimalStatus.Text; set => tbAnimalStatus.Text = value; }
        public int AdopterId 
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbAdopterId.Text, out value))
                {
                    return value;
                }

                return -1;
            }

            set => tbAdopterId.Text = value.ToString();
        }
        public string AdopterNamA { get => tbAdopterName.Text; set => tbAdopterName.Text = value; }
        public int AdopterAge { get => int.Parse(tbAdopterAge.Text); set => tbAdopterAge.Text = value.ToString(); }
        public string AdopterAddress { get => tbAdopterAddress.Text; set => tbAdopterAddress.Text = value; }
        public string AdopterNumber { get => tbAdopterNumber.Text; set => tbAdopterNumber.Text = value; }
        public string AdopterEmail { get => tbAdopterEmail.Text; set => tbAdopterEmail.Text = value; }
        public string VolunterName { get => tbVolunterName.Text; set => tbVolunterName.Text = value; }
        public DateTime AdoptionDate { get => dtpDate.Value; set => dtpDate.Value = value; }

        public event EventHandler OnClickGenerateNewAdoptionFormatButton;
        public event EventHandler OnClickClearFieldsButton;
        public event EventHandler OnClickSearchAnimalPictureEdit;
        public event EventHandler OnClickSearchAdopterPictureEdit;
        public event EventHandler OnChangeAnimalIdTextBox;
        public event EventHandler OnChangeAdopterIdTextBox;
        public event EventHandler OnLoadForm;

        public FormatNewAdoptionView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnGenerate.Click += delegate { OnClickGenerateNewAdoptionFormatButton.Invoke(btnGenerate, EventArgs.Empty); };
            btnClearField.Click += delegate { OnClickClearFieldsButton.Invoke(btnClearField, EventArgs.Empty); };
            peSeachAnimal.Click += delegate { OnClickSearchAnimalPictureEdit.Invoke(peSeachAnimal, EventArgs.Empty); };
            peSearchAdopter.Click += delegate { OnClickSearchAdopterPictureEdit.Invoke(peSearchAdopter, EventArgs.Empty); };
            tbAnimalId.TextChanged += delegate { OnChangeAnimalIdTextBox.Invoke(tbAnimalId, EventArgs.Empty); };
            tbAdopterId.TextChanged += delegate { OnChangeAdopterIdTextBox.Invoke(tbAdopterId, EventArgs.Empty); };
        }

        public void ClearFields()
        {
            tbAnimalId.Text = string.Empty;
            tbAdopterId.Text = string.Empty;
            tbVolunterName.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }

        public void ClearAdopterFields()
        {
            tbAdopterName.Text = string.Empty;
            tbAdopterAge.Text = string.Empty;
            tbAdopterAddress.Text = string.Empty;
            tbAdopterEmail.Text = string.Empty;
            tbAdopterNumber.Text = string.Empty;
        }

        public void ClearAnimalFields()
        {
            tbAnimalName.Text = string.Empty;
            tbAnimalSex.Text = string.Empty;
            tbAnimalBreed.Text = string.Empty;
            tbAnimalType.Text = string.Empty;
            tbAnimalStatus.Text = string.Empty;
            tbAnimalAge.Text = string.Empty;
            tbAnimalAdditionalInformation.Text = string.Empty;
        }
    }
}