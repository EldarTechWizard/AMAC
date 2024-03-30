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

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateVolunter
{
    public partial class FormatUpdateVolunterView : DevExpress.XtraEditors.XtraForm, IFormatUpdateVolunterView
    {
        public string Volunter { get => tbVolunter.Text; set => tbVolunter.Text = value; }
        public string Date { get => dtpDate.Text; set => dtpDate.Text = value; }

        public event EventHandler OnClickSaveButton;
        public event EventHandler OnClickClearFieldsButton;
        public FormatUpdateVolunterView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); };
            btnClearFields.Click += delegate { OnClickClearFieldsButton.Invoke(btnClearFields, EventArgs.Empty); };
        }
        

        private void ModificarDoc_Resp_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Size = this.Parent.Size;
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}