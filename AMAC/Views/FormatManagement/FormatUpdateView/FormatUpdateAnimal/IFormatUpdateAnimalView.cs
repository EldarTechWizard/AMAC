using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAnimal
{
    public interface IFormatUpdateAnimalView
    {
        int Id { get; set; }
        string NameA { get; set; }
        string AnimalType {  get; set; }
        string AnimalBreed { get; set; }
        string Sex { get; set; }
        bool Sterilized { get; set; }
        string AdditionalInformation { get; set; }

        event EventHandler OnClickSaveButton;
        event EventHandler OnClickClearFieldsButton;

        void LoadFields();
    }
}
