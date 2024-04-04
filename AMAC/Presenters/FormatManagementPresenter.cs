using AMAC.Views.AdopterManagement;
using AMAC.Views.FormatManagement;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatUpdateView;
using DbManagmentAMAC.Models;
using DevExpress.Dialogs.Core.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try 
            {
                IFormatNewAdoptionView tab = new FormatNewAdoptionView();
                new FormatNewAdoptionPresenter(tab, repository);          
                view.ChangeTab((Form)tab);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickUpdateAdoptionFormatButton(object sender, EventArgs e)
        {
            try
            {
                IFormatUpdateView tab = new FormatUpdateView();
                new FormatUpdatePresenter(tab, repository);
                view.ChangeTab((Form)tab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
