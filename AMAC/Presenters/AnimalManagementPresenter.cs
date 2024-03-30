using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class AnimalManagementPresenter
    {
        private IAnimalManagementView view;
        private IRepository repository;

        public AnimalManagementPresenter(IAnimalManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSaveAndEditAnimalButton += OnClickSaveAndEditAnimalButton;
            view.OnClickDeleteAnimalButton += OnClickDeleteAnimalButton;
            view.OnClickChoosePhotoButton += OnClickChoosePhotoButton;
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

        private void OnClickChoosePhotoButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickDeleteAnimalButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSaveAndEditAnimalButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
