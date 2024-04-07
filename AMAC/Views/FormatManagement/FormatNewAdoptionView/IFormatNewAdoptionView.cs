using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatNewAdoptionView
{
    public interface IFormatNewAdoptionView
    {

        /* Animal */
        int AnimalId { get; set; }
        string AnimalName { get; set; }
        string AnimalBreed { get; set; }
        int AnimalAge { get; set; }
        string AnimalSex { get; set; }
        bool AnimalSterilized { get; set; }
        string AnimalType { get; set; }
        string AnimalAdditionalInformation { get; set; }
        string AnimalStatus { get; set; }

        /* Adopter */
        int AdopterId { get; set; }
        string AdopterNamA { get; set; }
        int AdopterAge { get; set; }
        string AdopterAddress { get; set; }
        string AdopterNumber { get; set; }
        string AdopterEmail { get; set; }

        /* Volunter */
        string VolunterName { get; set; }
        DateTime AdoptionDate { get; set; }


        event EventHandler OnLoadForm;
        event EventHandler OnClickGenerateNewAdoptionFormatButton;
        event EventHandler OnClickClearFieldsButton;
        event EventHandler OnClickSearchAnimalPictureEdit;
        event EventHandler OnClickSearchAdopterPictureEdit;
        event EventHandler OnChangeAnimalIdTextBox;
        event EventHandler OnChangeAdopterIdTextBox;
 

        void SavePdf();
        void ClearFields();
        void ClearAdopterFields();
        void ClearAnimalFields();
        bool OpenPreviewTab(PdfGenerator generator);
        DataRow OpenSearchTableTab(DataTable data);
    }
}
