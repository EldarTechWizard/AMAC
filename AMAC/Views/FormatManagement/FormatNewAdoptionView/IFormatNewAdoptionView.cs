using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.FormatNewAdoptionView
{
    public interface IFormatNewAdoptionView
    {
        List<Action<bool>> Funcs { set; }

        Form AnimalForm { get; }
        Form AdopterForm { get; }
        Form ResponsabilityForm { get; }
    
        event EventHandler OnLoadForm;
        event EventHandler OnClickGenerateNewAdoptionFormatButton;
        event EventHandler OnClickClearFieldsButton;

        void LoadTabs(ref DataTable animalData, ref DataTable adopterData);
        void SavePdf();
        bool OpenPreviewTab(PdfGenerator generator);

        void ChangeSaveButtonMode(bool aux);
    }
}
