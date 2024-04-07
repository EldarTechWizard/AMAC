using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateVolunter
{
    public interface IFormatUpdateVolunterView
    {
        string Volunter { get; set; }
        DateTime Date { get; set; }
    }
}
