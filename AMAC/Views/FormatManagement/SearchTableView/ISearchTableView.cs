using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.SearchTableView
{
    public interface ISearchTableView
    {
        DataTable DataSource { get; set; }
        DataRow DataRow { get; set; }
        List<string> DataSourceCb { set; }
        string SelectedColumn { get; }
        string FilterText { get; }

        event EventHandler OnLoadForm;
        event EventHandler OnClickCloseButton;
        event EventHandler OnChangeFilterTextTextBox;
        event EventHandler OnClickSelectRowGridControl;
        void CloseTab();
        void SetDataRow();
        void SetCbColumnsPropierties();
    }
}
