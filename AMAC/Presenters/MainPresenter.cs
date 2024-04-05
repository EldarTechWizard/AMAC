using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using AMAC.Views.Main;
using AMAC.Views.RecordManagement;
using DbManagmentAMAC.Models;
using DbManagmentAMAC.Repository;
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
            view.OnClickAnimalManagementButton += OnClickAnimalManagementButton;
            view.OnClickAdopterManagementButton += OnClickAdopterManagementButton;
            view.OnClickFormatManagementButton += OnClickFormatManagementButton;
            view.OnClickRecordManagementButton += OnClickRecordManagementButton;
            view.OnClickCloseSesionButton += OnClickCloseSesionButton;

        }

        private void OnClickTabButtons(object sender, EventArgs e)
        {
            string buttonTag = ((Button)sender).Tag.ToString();

            Form tab = null;

            switch (buttonTag)
            {
                case "Animal":
                    IAnimalManagementView animalTab = null;
                    new AnimalManagementPresenter(animalTab, repository);
                    tab = (Form)animalTab;

                    break;
                case "Adopter":
                    IAdopterManagementView adopterTab = null;
                    new AdopterManagementPresenter(adopterTab, repository);
                    tab = (Form)adopterTab;

                    break;
                case "Format":
                    /*
                    IFormatManagementView formatTab = null;
                    new FormatManagementPresenter(formatTab, repository);
                    tab = (Form)formatTab;*/

                    break;
                case "Record":
                    IRecordManagementView recordTab = null;
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

        
        private void OnClickRecordManagementButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickFormatManagementButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickAdopterManagementButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickAnimalManagementButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void OnClickCloseSesionButton(object sender, EventArgs e)
        {
            view.CloseSesion();
        }
    }
}
