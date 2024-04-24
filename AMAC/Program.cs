using AMAC.Presenters;
using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.Login;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
using QuestPDF.Infrastructure;
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
            QuestPDF.Settings.License = LicenseType.Community;


            IRepository repository = new SqlServer("Server = LAPTOP-5C9UCS9L; Database = AMAC; Trusted_Connection = True;");

            //ILoginView login = new LoginView();
            //new LoginPresenter(login, repository);
            //((Form)login).ShowDialog();

            //if (!login.IsLogged) return;

            IMainView view = new MainView();
            new MainPresenter(view, repository);
            Application.Run((Form)view);


            //Application.Run(new Form1(repository));

        }
    }
}
