using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AMAC.Views.Login
{
    public partial class LoginView : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        private bool isLogged = false;
        public string UserName => tbUser.Text;

        public string Password => tbPassword.Text;

        public bool IsLogged { get => isLogged; set => isLogged = true; }
        public string LabelWarning { set => label2.Text = value; }

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        public event EventHandler OnClickLoginButton;
        public event EventHandler OnClickCancelButton;
        public event EventHandler OnClickHidePasswordPb;

        private void AssociateAndRaisedEvents()
        {
            btnLogin.Click += delegate { OnClickLoginButton.Invoke(btnLogin, EventArgs.Empty); };
            btnCancel.Click += delegate { OnClickCancelButton.Invoke(btnCancel, EventArgs.Empty); };
            pbHide.Click += delegate { OnClickHidePasswordPb.Invoke(pbHide, EventArgs.Empty); };
            pbShow.Click += delegate { OnClickHidePasswordPb.Invoke(pbShow, EventArgs.Empty); };
        }

       
        public void CloseForm()
        {
            this.Close();
        }

        public void HidePassword()
        {
            if(tbPassword.UseSystemPasswordChar)
            {
                tbPassword.UseSystemPasswordChar = false;
                pbHide.Image = AMAC.Properties.Resources.visible;
                return;
            }

            tbPassword.UseSystemPasswordChar = true;
            pbHide.Image = AMAC.Properties.Resources.invisible;
        }

        public void ShowErrorMessage()
        {
            label2.Visible = true;
            label2.Text = "Usuario y/o Contraseña incorrectos";
        }
    }
}
