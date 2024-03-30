using AMAC.Views.AdopterManagement;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class AdopterManagementPresenter
    {
        private IAdopterManagementView view;
        private IRepository repository;
        public AdopterManagementPresenter(IAdopterManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickDeleteButton += OnClickDeleteButton;
            view.OnClickSaveAndEditButton += OnClickSaveAndEditButton;
            view.OnClickSearchPictureEdit += OnClickSearchPictureEdit;
            view.OnLoadForm += OnLoadForm;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSearchPictureEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSaveAndEditButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickDeleteButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

