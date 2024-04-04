using AMAC.Presenters;
using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IAnimalManagementView view = new AnimalManagementView();
            IRepository repository = new SqlServer("Server=ASUSTUF;Database=AMAC;Trusted_Connection=True;");
            new AnimalManagementPresenter(view,repository);
            Application.Run((Form)view);
        }
    }
}
