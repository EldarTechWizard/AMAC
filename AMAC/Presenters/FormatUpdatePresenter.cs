using AMAC.Views.FormatManagement.FormatUpdateView;
using AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAdopter;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatUpdatePresenter
    {
        private IFormatUpdateView view;
        private IRepository repository;
        public FormatUpdatePresenter(IFormatUpdateView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickAdopterButton += OnClickAdopterButton;
            view.OnClickAnimalButton += OnClickAnimalButton;
            view.OnClickVolunterButton += OnClickVolunterButton;
        }

        private void OnClickVolunterButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickAnimalButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickAdopterButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
