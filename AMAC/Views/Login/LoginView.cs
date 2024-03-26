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


        private void pbShow_Click(object sender, EventArgs e)
        {
            pbHide.Visible = true;
            pbShow.Visible = false;
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbShow.Visible = true;
            pbHide.Visible = false;
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
