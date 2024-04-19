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

        event EventHandler OnLoadForm;
        event EventHandler OnClickCloseButton;
        event EventHandler OnClickSelectRowGridControl;
        void CloseTab();
        void SetDataRow();

    }
}
