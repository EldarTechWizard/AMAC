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
        string PicturePath { get; }
        string NameA { get; }
        string AnimalBreed { get; }
        int Age { get; }
        string Sex { get; }
        bool Sterilized {  get; }
        string AnimalType { get; }
        string AdditionalInformation { get; }
        bool EditMode { get; }

        event EventHandler OnLoadForm;
        event EventHandler OnClickSaveAndEditAnimalButton;
        event EventHandler OnClickDeleteAnimalButton;
        event EventHandler OnClickChoosePhotoButton;
        event EventHandler OnClickSearchPictureEdit;

        void ChangeEditMode();
        void ClearFields();
    }
}
