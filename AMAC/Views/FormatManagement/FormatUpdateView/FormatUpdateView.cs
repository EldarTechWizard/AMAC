using AMAC.Presenters;
using AMAC.Views.FormatManagement.FormatNewAdoptionView;
using AMAC.Views.FormatManagement.FormatPreviewView;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.FormatManagement.FormatUpdateView
{
    public partial class FormatUpdateView : DevExpress.XtraEditors.XtraForm, IFormatUpdateView
    {

        private Form currentTab = null;

        private int reportId = -1;
        private int animalId = -1;
        private int adopterId = -1;
        private string volunter = "";
        private DateTime date = DateTime.Now;
        public Form CurrentTab => currentTab;

        public int AnimalId { get => animalId; set => animalId = value; }
        public int AdopterId { get => adopterId; set => adopterId = value; }
        public string Volunter { get => volunter; set => volunter = value; }
        public DateTime AdoptionDate { get => date; set => date = value; }
        public DataTable DataSource { get => (DataTable)cbPdfFormats.Properties.DataSource ; set => cbPdfFormats.Properties.DataSource = value; }

        public DataRowView CurrentData => (DataRowView)cbPdfFormats.EditValue;

        public int Id { get => reportId; set => reportId = value; }

        public event EventHandler OnClickTabButtons;
        public event EventHandler OnLoadForm;
        public event EventHandler OnClickSaveButton;
        public event EventHandler OnChangeFormatIdLookUpEdit;
        public event EventHandler OnClickPrintPdfButton;
        public event EventHandler OnClickDeleteButton;

        public FormatUpdateView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); }; ;
            btnSave.Click += delegate { OnClickSaveButton.Invoke(btnSave, EventArgs.Empty); }; ; ;
            btnAdopter.Click += delegate { OnClickTabButtons.Invoke(btnAdopter, EventArgs.Empty); };
            btnAnimal.Click += delegate { OnClickTabButtons.Invoke(btnAnimal, EventArgs.Empty); };
            btnVolunter.Click += delegate { OnClickTabButtons.Invoke(btnVolunter, EventArgs.Empty); };
            cbPdfFormats.EditValueChanged += delegate { OnChangeFormatIdLookUpEdit.Invoke(cbPdfFormats, EventArgs.Empty); };
            btnPrint.Click += delegate { OnClickPrintPdfButton.Invoke(btnPrint, EventArgs.Empty); };
            btnDelete.Click += delegate { OnClickDeleteButton.Invoke(btnDelete, EventArgs.Empty); };
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

        public void SetLookUpEditPropierties()
        {
            cbPdfFormats.Properties.DisplayMember = "animalName";
        }

        public void SavePdf()
        {
            string path = "";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Formato de adopcion";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                File.Copy("temp.pdf", path);
            }


        }

        public bool OpenPreviewTab(PdfGenerator generator)
        {
            IFormatPreviewView view = new FormatPreviewView.FormatPreviewView();
            new FormatPreviewPresenter(view, generator);
            Form temp = (Form)view;
            temp.ShowDialog();

            temp.Dispose();
            return view.IsCorrect;
        }

        public void CloseCurrentTab()
        {
            if(currentTab != null)
            {
                currentTab.Close();
                currentTab = null;
            }
        }
    }
}