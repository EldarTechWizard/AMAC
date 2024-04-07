
using AMAC.Views.FormatManagement.FormatControls.FormatVolunterView;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class FormatVolunterPresenter
    {
        private IFormatVolunterView view;
        public FormatVolunterPresenter(IFormatVolunterView view)
        {
            this.view = view;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
        }
        
    }
}
