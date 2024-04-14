using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.AdopterManagement
{
    public interface IAdopterManagementView
    {
        DataTable DataSource { get; set; }
        bool EditMode { get; set; }
        int Id { get; set; }
        string NameA { get; set; }
        int Age { get; set; }
        string Address { get; set; }
        string Number { get; set; }
        string Email { get; set; }

        event EventHandler OnClickGenerateInsertButton;
        event EventHandler OnClickSelectRowGridControl;
        event EventHandler OnClickSaveAndEditButton;
        event EventHandler OnClickDeleteButton;

        event EventHandler OnChangedAdopterIdTextBox;
        event EventHandler OnLoadForm;

        void ChangeEditMode(bool aux);
        void ClearFields();
        void LoadInfoFromSelectedRow();

    }
}
