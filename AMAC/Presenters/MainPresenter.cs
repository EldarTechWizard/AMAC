using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using AMAC.Views.FormatManagement;
using AMAC.Views.Main;
using AMAC.Views.RecordManagement;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Presenters
{
    public class MainPresenter
    {
        private IMainView view;
        private IRepository repository;
        public MainPresenter(IMainView view, IRepository repository) 
        {
            this.view = view;   
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnLoadMain += OnLoadMain;
            view.OnClickTabButtons += OnClickTabButtons;
            view.OnClickCloseSesionButton += OnClickCloseSesionButton;

        }

        private void OnClickTabButtons(object sender, EventArgs e)
        {
            string buttonTag = ((SimpleButton)sender).Tag.ToString();

            Form tab = null;

            switch (buttonTag)
            {
                case "Animal":
                    IAnimalManagementView animalTab = new AnimalManagementView();
                    new AnimalManagementPresenter(animalTab, repository);
                    tab = (Form)animalTab;

                    break;
                case "Adopter":
                    IAdopterManagementView adopterTab = new AdopterManagementView();
                    new AdopterManagementPresenter(adopterTab, repository);
                    tab = (Form)adopterTab;

                    break;
                case "Format":
                    
                    IFormatManagementView formatTab = new FormatManagementView();
                    new FormatManagementPresenter(formatTab, repository);
                    tab = (Form)formatTab;

                    break;
                case "Record":
                    IRecordManagementView recordTab = new RecordManagementView();
                    new RecordManagementPresenter(recordTab, repository);
                    tab = (Form)recordTab;

                    break;
                default:
                    throw new ArgumentException("Error al cambiar una nueva pestaña");
            }

            view.ChangeTab(tab);
        }

        private void OnLoadMain(object sender, EventArgs e)
        {
            view.WelcomeText = "AMAC AC GUASAVE, SINALOA\r\nBienvenida/o " + view.UserName;
        }

        

        private void OnClickCloseSesionButton(object sender, EventArgs e)
        {
            view.CloseSesion();
        }
    }
}
