using AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateVolunter;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatUpdateVolunterPresenter
    {
        private IFormatUpdateVolunterView view;
        private IRepository repository;
        public FormatUpdateVolunterPresenter(IFormatUpdateVolunterView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSaveButton += OnClickSaveButton;
            view.OnClickClearFieldsButton += OnClickClearFieldsButton;
        }

        private void OnClickClearFieldsButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSaveButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
