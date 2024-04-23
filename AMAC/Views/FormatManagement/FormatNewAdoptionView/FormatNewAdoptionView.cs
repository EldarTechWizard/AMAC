using AMAC.Presenters;
using AMAC.Views.FormatManagement.FormatControls.FormatAdopterView;
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
using AMAC.Views.FormatManagement.FormatControls.FormatVolunterView;
using AMAC.Views.FormatManagement.FormatPreviewView;
using AMAC.Views.FormatManagement.SearchTableView;
using DevExpress.Utils.CommonDialogs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMAC.Views.FormatManagement.FormatNewAdoptionView
{
    public partial class FormatNewAdoptionView : DevExpress.XtraEditors.XtraForm, IFormatNewAdoptionView
    {
        private Form animalForm = null;
        private Form adopterForm = null;
        private Form responsabilityForm = null;    
        public Form AnimalForm => animalForm;

        public Form AdopterForm => adopterForm;

        public Form ResponsabilityForm => responsabilityForm;


        public event EventHandler OnClickGenerateNewAdoptionFormatButton;
        public event EventHandler OnClickClearFieldsButton;
        public event EventHandler OnLoadForm;


        public FormatNewAdoptionView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            this.Load += delegate { OnLoadForm.Invoke(this, EventArgs.Empty); };
            btnGenerate.Click += delegate { OnClickGenerateNewAdoptionFormatButton.Invoke(btnGenerate, EventArgs.Empty); };
            btnClearField.Click += delegate { OnClickClearFieldsButton.Invoke(btnClearField, EventArgs.Empty); };
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

        public DataRow OpenSearchTableTab(DataTable data)
        {
            ISearchTableView view = new SearchTableView.SearchTableView();
            new SearchTablePresenter(view, data);
            Form temp = (Form)view;
            temp.ShowDialog();

            return view.DataRow;
        }

        public void LoadTabs(ref DataTable animalData, ref DataTable adopterData)
        {
            LoadAnimalTab(ref animalData);
            LoadAdopterTab(ref adopterData);
            LoadResponsabilityTab();
        }

        private void LoadAnimalTab(ref DataTable animalData)
        {
            IFormatAnimalView animalTab = new FormatAnimalView();
            new FormatAnimalPresenter(animalTab, animalData);
            this.animalForm = (Form)animalTab;

            animalForm.TopLevel = false;
            panel2.Controls.Add(animalForm);
            animalForm.Dock = DockStyle.Fill;
            animalForm.Show();
        }

        private void LoadAdopterTab(ref DataTable adopterData)
        {
            IFormatAdopterView adopterTab = new FormatAdopterView();
            new FormatAdopterPresenter(adopterTab, adopterData);
            this.adopterForm = (Form)adopterTab;


            adopterForm.TopLevel = false;
            panel3.Controls.Add(adopterForm);
            adopterForm.Dock = DockStyle.Fill;
            adopterForm.Show();
        }

        private void LoadResponsabilityTab()
        {
            IFormatVolunterView responsabilityTab = new FormatVolunterView();
            new FormatVolunterPresenter(responsabilityTab);
            this.responsabilityForm = (Form)responsabilityTab;
            
            responsabilityForm.TopLevel = false;
            panel4.Controls.Add(responsabilityForm);
            responsabilityForm.Dock = DockStyle.Fill;
            responsabilityForm.Show();

        }
    }
}