using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.FormatUpdateView
{
    public interface IFormatUpdateView
    {
        DataTable DataSource { get; set; }
        Form CurrentTab { get; }

        int Id {  get; set; } 
        int AnimalId { get; set; }
        int AdopterId { get; set; }
        string Volunter {  get; set; }
        DateTime AdoptionDate { get; set; }
        DataRowView CurrentData {  get; }
        

        event EventHandler OnLoadForm;
        event EventHandler OnClickTabButtons;
        event EventHandler OnClickSaveButton;
        event EventHandler OnChangeFormatIdLookUpEdit;
        event EventHandler OnClickPrintPdfButton;
        event EventHandler OnClickDeleteButton;

        void ChangeTab(Form tab);
        void SetLookUpEditPropierties();
        bool OpenPreviewTab(PdfGenerator generator);
        void SavePdf();
        void CloseCurrentTab();
    }
}
