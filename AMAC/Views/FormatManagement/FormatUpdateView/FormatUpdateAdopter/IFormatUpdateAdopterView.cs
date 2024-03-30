using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAdopter
{
    public interface IFormatUpdateAdopterView
    {
        int Id { get; set; }
        string NameA { get; set; }
        int Age { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string AdditionaInformation { get; set; }

        event EventHandler OnClickSaveButton;
        event EventHandler OnClickClearFieldsButton;

        void ClearFields();
        void LoadFields();
    }
}
