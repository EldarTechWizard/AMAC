using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement
{
    public interface IFormatManagementView
    {
        event EventHandler OnClickNewAdoptionFormatButton;
        event EventHandler OnClickUpdateAdoptionFormatButton;
        void ChangeTab(Form tab);
    }
}
