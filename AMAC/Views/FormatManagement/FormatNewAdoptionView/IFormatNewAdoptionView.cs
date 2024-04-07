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
        Form AnimalForm { get; }
        Form AdopterForm { get; }
        Form ResponsabilityForm { get; }
    
        event EventHandler OnLoadForm;
        event EventHandler OnClickGenerateNewAdoptionFormatButton;

        void LoadTabs(ref DataTable animalData, ref DataTable adopterData);
        void SavePdf();
        bool OpenPreviewTab(PdfGenerator generator);
        DataRow OpenSearchTableTab(DataTable data);
    }
}
