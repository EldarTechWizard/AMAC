using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.RecordManagement
{
    public interface IRecordManagementView
    {
        DataTable DataSource { get; set; }
        string SelectedColumn { get; }
        string FilterText { get; }

        event EventHandler OnLoadForm;
        event EventHandler OnChangeFilterTextTextBox;

    }
}
