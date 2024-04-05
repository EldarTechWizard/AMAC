using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatPreviewView
{
    public interface IFormatPreviewView
    {
        bool IsCorrect {  get; }

        event EventHandler OnLoadForm;
        event EventHandler OnClickSaveButton;
        event EventHandler OnClickCloseButton;

        void CloseWithFlag(bool flag);
        void SetPdfViewer(string path);
    }
}
