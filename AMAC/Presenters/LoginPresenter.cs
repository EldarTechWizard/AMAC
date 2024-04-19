using AMAC.Views.Login;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private IRepository repository;
        private DataTable data = new DataTable();
        public LoginPresenter(ILoginView view, IRepository repository) 
        { 
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadForm += OnLoadForm;
            view.OnClickLoginButton += OnClickLoginButton;
            view.OnClickCancelButton += OnClickCancelButton;
            view.OnClickHidePasswordPb += OnClickHidePasswordPb;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {

                if (!repository.SelectUsers(data)) throw new Exception(repository.LastError);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickHidePasswordPb(object sender, EventArgs e)
        {
            view.HidePassword();
        }

        private void OnClickCancelButton(object sender, EventArgs e)
        {
            view.CloseForm();
        }

        private void OnClickLoginButton(object sender, EventArgs e)
        {
            try
            {
                
                if(!data.AsEnumerable().Any(rowD => (rowD.Field<string>("name") == view.UserName) && (rowD.Field<string>("password") == view.Password) ))  throw new Exception(repository.LastError);

                view.IsLogged = true;
                view.CloseForm();
            }
            catch(Exception ex)
            {
                view.ShowErrorMessage();
            }
        }
    }
}
