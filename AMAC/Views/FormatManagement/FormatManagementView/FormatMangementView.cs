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

namespace AMAC.Views.FormatManagement.FormatManagementView
{
    public partial class FormatManagementView : DevExpress.XtraEditors.XtraForm, IFormatManagementView
    {
        private Form currentTab;

        public event EventHandler OnClickNewAdoptionFormatButton;
        public event EventHandler OnClickUpdateAdoptionFormatButton;
        public FormatManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            btnCreateNewAdoptionFormat.Click += delegate { OnClickNewAdoptionFormatButton.Invoke(btnCreateNewAdoptionFormat, EventArgs.Empty); };
            btnUpdateAdoptionFormat.Click += delegate { OnClickUpdateAdoptionFormatButton.Invoke(btnUpdateAdoptionFormat, EventArgs.Empty); };
        }

        public void ChangeTab(Form tab)
        {
            panel1.Controls.Clear();
            if (tab != null)
            {
                tab.Close();
            }
            tab.TopLevel = false;
            currentTab = tab;
            panel1.Controls.Add(currentTab);
            currentTab.Dock = DockStyle.Fill;
            currentTab.Show();
        }

        
    }
}