using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.FormatUpdateView
{
    public interface IFormatUpdateView
    {
        event EventHandler OnClickAnimalButton;
        event EventHandler OnClickAdopterButton;
        event EventHandler OnClickVolunterButton;
        void ChangeTab(Form tab);
    }
}
