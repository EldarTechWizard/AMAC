using AMAC.Views.AdopterManagement;
using AMAC.Views.RecordManagement;
using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Presenters
{
    public class RecordManagementPresenter
    {
        private IRecordManagementView view;
        private IRepository repository;

        public RecordManagementPresenter(IRecordManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }
}
