using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class AnimalManagementPresenter
    {
        private IAnimalManagementView view;
        private IRepository repository;

        public AnimalManagementPresenter(IAnimalManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }
}
