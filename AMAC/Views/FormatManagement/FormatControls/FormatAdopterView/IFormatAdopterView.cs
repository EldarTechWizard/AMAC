using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatControls.FormatAdopterView
{
    public interface IFormatAdopterView
    {
        int Id { get; set; }
        string NameA { get; set; }
        int Age { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Number { get; set; }

        event EventHandler OnChangeAdopterIdTextBox;
        event EventHandler OnClickSearchAdopterPictureEdit;

        DataRow OpenSearchTableTab(DataTable data);
        void ClearAdopterFields();
    }
}
