using AMAC.Views.Login;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        public LoginPresenter(ILoginView view) 
        { 
            this.view = view;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickLoginButton += OnClickLoginButton;
            view.OnClickCancelButton += OnClickCancelButton;
            view.OnClickHidePasswordPb += OnClickHidePasswordPb;
        }

        private void OnClickHidePasswordPb(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickCancelButton(object sender, EventArgs e)
        {
            view.CloseForm();
        }

        private void OnClickLoginButton(object sender, EventArgs e)
        {
            try
            {
                IRepository repository = new SqlServer();

                if(!repository.Login(view.UserName, view.Password) )  throw new Exception(repository.LastError);

                view.IsLogged = true;
                view.CloseForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
