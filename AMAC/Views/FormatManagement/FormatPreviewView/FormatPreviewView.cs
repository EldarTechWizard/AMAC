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

namespace AMAC.Views.FormatManagement.FormatPreviewView
{
    public partial class FormatPreviewView : DevExpress.XtraEditors.XtraForm, IFormatPreviewView
    {
        public FormatPreviewView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        public event EventHandler OnClickSaveButton;
        public event EventHandler OnClickCloseButton;

        private void AssociateAndRaisedEvents()
        {
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); };
            btnClose.Click += delegate { OnClickCloseButton.Invoke(btnClose, EventArgs.Empty); };
        }

        
    }
}