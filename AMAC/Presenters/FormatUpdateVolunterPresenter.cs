using AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateVolunter;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatUpdateVolunterPresenter
    {
        private IFormatUpdateVolunterView view;
        public FormatUpdateVolunterPresenter(IFormatUpdateVolunterView view)
        {
            this.view = view;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
        }

    }
}
