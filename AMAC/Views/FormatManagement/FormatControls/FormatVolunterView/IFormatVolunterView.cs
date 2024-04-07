using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatControls.FormatVolunterView
{
    public interface IFormatVolunterView
    {
        string Volunter { get; set; }
        DateTime Date { get; set; }
    }
}
