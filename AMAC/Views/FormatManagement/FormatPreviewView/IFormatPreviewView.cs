using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatPreviewView
{
    public interface IFormatPreviewView
    {
        event EventHandler OnClickSaveButton;
        event EventHandler OnClickCloseButton;
    }
}
