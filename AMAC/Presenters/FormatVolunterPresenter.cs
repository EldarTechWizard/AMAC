
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
        private Action<bool> CheckStateId;
        public FormatVolunterPresenter(IFormatVolunterView view, Action<bool> checkStateId)
        {
            this.view = view;
            AssociateAndRaisedEvents();
            CheckStateId = checkStateId;
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnChangeTextBox += OnChangeTextBox;
        }

        private void OnChangeTextBox(object sender, EventArgs e)
        {
            if(view.Volunter != "") 
            {
                CheckStateId(true);
                return;
            }

            CheckStateId(false);
        }
    }
}
