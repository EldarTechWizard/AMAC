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

namespace AMAC.Views.FormatManagement.FormatControls.FormatVolunterView
{
    public partial class FormatVolunterView : DevExpress.XtraEditors.XtraForm, IFormatVolunterView
    {
        public string Volunter { get => tbVolunter.Text; set => tbVolunter.Text = value; }
        public DateTime Date { get => dtpDate.Value; set => dtpDate.Value = value; }

        public FormatVolunterView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            
        }

        public void ClearFields()
        {
            tbVolunter.Text = "";
            dtpDate.Value = DateTime.Now;
        }
    }
}