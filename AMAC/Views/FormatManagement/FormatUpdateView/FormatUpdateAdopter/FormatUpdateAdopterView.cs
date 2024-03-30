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

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAdopter
{
    public partial class FormatUpdateAdopterView : DevExpress.XtraEditors.XtraForm , IFormatUpdateAdopterView
    {
        public int Id { get => int.Parse(lbId.Text); set => lbId.Text = value.ToString(); }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
        public int Age { get => int.Parse(tbAge.Text); set => tbAge.Text = value.ToString(); }
        public string Address { get => tbAddress.Text; set => tbAddress.Text = value; }
        public string Email { get => tbEmail.Text; set => tbEmail.Text = value; }
        public string AdditionaInformation { get => tbAdditionalInformation.Text; set => tbAdditionalInformation.Text = value; }

        public event EventHandler OnClickSaveButton;
        public event EventHandler OnClickClearFieldsButton;
        public FormatUpdateAdopterView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); };
            btnClearFields.Click += delegate { OnClickClearFieldsButton.Invoke(btnClearFields, EventArgs.Empty); };
        }

        public void ClearFields()
        {
            throw new NotImplementedException();
        }

        public void LoadFields()
        {
            throw new NotImplementedException();
        }

        private void ModificarDoc_Adopt_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Size = this.Parent.Size;
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}