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

namespace AMAC.Views.Main
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm, IMainView
    {
        private string userName;
        private Form currentChildForm;

        public Form ActiveTab => throw new NotImplementedException();

        //public string WelcomeText { set => label4.Text = value; }
        public string UserName { get => userName; set => userName = value; }

        public event EventHandler OnLoadMain;
        public event EventHandler OnClickCloseSesionButton;
        public event EventHandler OnClickTabButtons;

        public MainView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AssociateAndRaisedEvents()
        {
            Load += delegate { OnLoadMain.Invoke(this, EventArgs.Empty); };
            btnAnimalManagement.Click += delegate { OnClickTabButtons.Invoke(this.btnAnimalManagement, EventArgs.Empty); };
            btnFormatManagement.Click += delegate { OnClickTabButtons.Invoke(this.btnFormatManagement, EventArgs.Empty); };
            btnAdopterManagement.Click += delegate { OnClickTabButtons.Invoke(this.btnAdopterManagement, EventArgs.Empty); };
            ///btnCloseSesion.Click += delegate { OnClickCloseSesionButton.Invoke(this, EventArgs.Empty); };
         
        }             

        public void ChangeTab(Form view)
        {
            panel1.Controls.Clear();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            view.TopLevel = false;
            currentChildForm = view;
            panel1.Controls.Add(currentChildForm);
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.Show();
        }

        public void CloseSesion()
        {
            this.Close();
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {

        }
    }
}