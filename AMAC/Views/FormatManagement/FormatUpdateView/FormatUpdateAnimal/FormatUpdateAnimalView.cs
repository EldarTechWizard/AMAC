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

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAnimal
{
    public partial class FormatUpdateAnimalView : DevExpress.XtraEditors.XtraForm, IFormatUpdateAnimalView
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
        public string AnimalType { get => tbAnimalType.Text; set => tbAnimalType.Text = value; }
        public string AnimalBreed { get => tbAnimalBreed.Text; set => tbAnimalBreed.Text = value; }
        public string Sex { get => cbSex.Text; set => cbSex.Text = value; }
        public bool Sterilized { get => chbSterilized.Checked; set => chbSterilized.Checked = value; }
        public string AdditionalInformation { get => tbAdditionalInformation.Text; set => tbAdditionalInformation.Text = value; }

        public event EventHandler OnClickSaveButton;
        public event EventHandler OnClickClearFieldsButton;
        public FormatUpdateAnimalView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); };
            btnClearFields.Click += delegate { OnClickClearFieldsButton.Invoke(btnSave, EventArgs.Empty); };
        }

        

        public void LoadFields()
        {
            throw new NotImplementedException();
        }

        private void ModificarDoc_Mascota_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Size = this.Parent.Size;
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}