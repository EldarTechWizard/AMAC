using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.AnimalManagement
{
    public interface IAnimalManagementView
    {
        DataTable DataSource { get; set; }


        //Animal Propierties
        int Id { get; set; }
        string PicturePath { get; set; }
        string NameA { get; set; }
        string AnimalBreed { get; set; }
        int Age { get; set; }
        string Sex { get; set; }
        bool Sterilized {  get; set; }
        string AnimalType { get; set; }
        string AdditionalInformation { get; set; }
        string Status {  get; set; }

        //PetReport Propierties

        DateTime RescuedDate { get; set; }
        string TemporaryHome { get; set; }
        string Rescuer {  get; set; }
        string Veterinarian { get; set; }
        string Diagnostic {  get; set; }

        //Form Propierties
        bool EditMode { get; set; }

        event EventHandler OnLoadForm;

        event EventHandler OnClickGenerateInsertButton;
        event EventHandler OnClickSaveAndEditAnimalButton;
        event EventHandler OnClickDeleteAnimalButton;
        event EventHandler OnClickChoosePhotoButton;

        event EventHandler OnChangedAdopterIdTextBox;
        event EventHandler OnClickSelectRowGridControl;
        void ChooseImage();
        void ChangeEditMode(bool aux);

        void SetDisplayNumbers(int adopted, int temphHome, int deceased);
        void LoadInfoFromSelectedRow();
        void ClearFields();

    }
}
