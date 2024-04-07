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
        public DateTime Date { get => dtpDate.Value; set => dtpDate.Value = value; }

        public FormatUpdateVolunterView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            
        }
        
    }
}