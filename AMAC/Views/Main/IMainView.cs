using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.Main
{
    public interface IMainView
    {
        string UserName { get; set; }
        //string WelcomeText { set; }
        Form ActiveTab { get; }

        event EventHandler OnLoadMain;
        event EventHandler OnClickTabButtons;
        event EventHandler OnClickCloseSesionButton;
        void ChangeTab(Form view);
        void CloseSesion();
    }
}
