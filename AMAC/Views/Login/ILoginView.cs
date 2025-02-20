﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.Login
{
    public interface ILoginView
    {
        bool IsLogged {  get; set; }        
        string LabelWarning { set; }
        string UserName { get; }
        string Password { get; }

        event EventHandler OnLoadForm;
        event EventHandler OnClickLoginButton;
        event EventHandler OnClickCancelButton;
        event EventHandler OnClickHidePasswordPb;
        void CloseForm();
        void HidePassword();
        void ShowErrorMessage();
    }
}
