using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement.FormatPreviewView;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatPreviewPresenter
    {
        private IFormatPreviewView view;


        public FormatPreviewPresenter(IFormatPreviewView view)
        {
            this.view = view;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSaveButton += OnClickSaveButton;
            view.OnClickCloseButton += OnClickCloseButton;
        }

        private void OnClickCloseButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSaveButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
