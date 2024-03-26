using AMAC.Views.AdopterManagement;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class AdopterManagementPresenter
    {
        private IAdopterManagementView view;
        private IRepository repository;
        public AdopterManagementPresenter(IAdopterManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }
}
