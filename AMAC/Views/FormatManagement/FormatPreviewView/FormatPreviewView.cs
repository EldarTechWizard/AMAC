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
        private bool isCorrect = false;
        public FormatPreviewView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        public bool IsCorrect => isCorrect;

        public event EventHandler OnClickSaveButton;
        public event EventHandler OnClickCloseButton;
        public event EventHandler OnLoadForm;

        public void CloseWithFlag(bool flag)
        {         
            isCorrect = flag;
            this.Close();
        }

        public void SetPdfViewer(string p)
        {
            pdfViewer1.DocumentFilePath = p;
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); };
            btnClose.Click += delegate { OnClickCloseButton.Invoke(btnClose, EventArgs.Empty); };
        }

        
    }
}