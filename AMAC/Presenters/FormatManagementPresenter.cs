using AMAC.Views.AdopterManagement;
using AMAC.Views.FormatManagement.FormatManagementView;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatManagementPresenter
    {
        private IFormatManagementView view;
        private IRepository repository;

        public FormatManagementPresenter(IFormatManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickUpdateAdoptionFormatButton += OnClickUpdateAdoptionFormatButton;
            view.OnClickNewAdoptionFormatButton += OnClickNewAdoptionFormatButton;
        }

        private void OnClickNewAdoptionFormatButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickUpdateAdoptionFormatButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
