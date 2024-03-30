using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.FormatUpdateView
{
    public partial class FormatUpdateView : DevExpress.XtraEditors.XtraForm,IFormatUpdateView
    {
        private Form currentTab;

        public event EventHandler OnClickAnimalButton;
        public event EventHandler OnClickAdopterButton;
        public event EventHandler OnClickVolunterButton;
        public FormatUpdateView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnAnimal.Click += delegate { OnClickAnimalButton.Invoke(btnAnimal, EventArgs.Empty); };
            btnAdopter.Click += delegate { OnClickAdopterButton.Invoke(btnAdopter, EventArgs.Empty); };
            btnVolunter.Click += delegate { OnClickVolunterButton.Invoke(btnVolunter, EventArgs.Empty); };
        }

        

        public void ChangeTab(Form tab)
        {
            panelSubTab.Controls.Clear();
            if (currentTab != null)
            {
                currentTab.Close();
            }

            tab.TopLevel = false;
            currentTab = tab;
            panelSubTab.Controls.Add(currentTab);
            currentTab.Dock = DockStyle.Fill;
            currentTab.Show();
        }

       
    }
}