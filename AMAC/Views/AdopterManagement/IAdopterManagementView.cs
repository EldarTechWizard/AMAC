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
        bool EditMode { get; }
        string Name { get; }
        string Age { get; }
        string Address { get; }
        string Number { get; }
        string Email { get; }

        event EventHandler OnClickSaveAndEditButton;
        event EventHandler OnClickDeleteButton;
        event EventHandler OnClickSearchPictureEdit;
        event EventHandler OnLoadForm;
        void ChangeEditMode();
        void ClearFields();

    }
}
