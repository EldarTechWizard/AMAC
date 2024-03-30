using AMAC.Views.FormatManagement.FormatManagementView;
using AMAC.Views.FormatManagement.SearchTableView;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class SearchTablePresenter
    {
        private ISearchTableView view;
        private IRepository repository;

        public SearchTablePresenter(ISearchTableView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickCloseButton += OnClickCloseButton;
            view.OnChangeFilterTextTextBox += OnChangeFilterTextTextBox;
        }

        private void OnChangeFilterTextTextBox(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickCloseButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
