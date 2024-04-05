using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatPreviewView;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class FormatPreviewPresenter
    {
        private IFormatPreviewView view;
        private PdfGenerator pdfGenerator;

        public FormatPreviewPresenter(IFormatPreviewView view, PdfGenerator _pdfGenerator)
        {
            this.view = view;
            this.pdfGenerator = _pdfGenerator;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSaveButton += OnClickSaveButton;
            view.OnClickCloseButton += OnClickCloseButton;
            view.OnLoadForm += OnLoadForm;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                pdfGenerator.GeneratePdf("temp.pdf");
                view.SetPdfViewer("temp.pdf");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickCloseButton(object sender, EventArgs e)
        {
            view.CloseWithFlag(false);
        }

        private void OnClickSaveButton(object sender, EventArgs e)
        {
            view.CloseWithFlag(true);
        }
    }
}
