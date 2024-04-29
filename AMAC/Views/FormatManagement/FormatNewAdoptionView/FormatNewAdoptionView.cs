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

        private List<Action<bool>> funcs;
        private Form animalForm = null;
        private Form adopterForm = null;
        private Form responsabilityForm = null;    
        public Form AnimalForm => animalForm;
        public Form AdopterForm => adopterForm;
        public Form ResponsabilityForm => responsabilityForm;

        public List<Action<bool>> Funcs { set => funcs = value; }

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


        public void LoadTabs()
        {
            LoadAnimalTab();
            LoadAdopterTab();
            LoadResponsabilityTab();
        }

        public void ReloadInfoTabs(DataTable animalData, DataTable adopterData)
        {
            if (animalData.AsEnumerable().Any(row => row.Field<string>("status") != "Adoptado"))
                animalData = animalData.AsEnumerable().Where(row => row.Field<string>("status") != "Adoptado").CopyToDataTable();
            else
                animalData.Rows.Clear();

            ((IFormatAnimalView)this.animalForm).DataSource = animalData;
            ((IFormatAdopterView)this.adopterForm).DataSource = adopterData;
        }

        private void LoadAnimalTab()
        {
            IFormatAnimalView animalTab = new FormatAnimalView();
            new FormatAnimalPresenter(animalTab, funcs[0]);
            this.animalForm = (Form)animalTab;

            animalForm.TopLevel = false;
            panel2.Controls.Add(animalForm);
            animalForm.Dock = DockStyle.Fill;
            animalForm.Show();
        }

        private void LoadAdopterTab()
        {
            IFormatAdopterView adopterTab = new FormatAdopterView();
            new FormatAdopterPresenter(adopterTab, funcs[1]);
            this.adopterForm = (Form)adopterTab;


            adopterForm.TopLevel = false;
            panel3.Controls.Add(adopterForm);
            adopterForm.Dock = DockStyle.Fill;
            adopterForm.Show();
        }

        private void LoadResponsabilityTab()
        {
            IFormatVolunterView responsabilityTab = new FormatVolunterView();
            new FormatVolunterPresenter(responsabilityTab, funcs[2]);
            this.responsabilityForm = (Form)responsabilityTab;
            
            responsabilityForm.TopLevel = false;
            panel4.Controls.Add(responsabilityForm);
            responsabilityForm.Dock = DockStyle.Fill;
            responsabilityForm.Show();

        }

        public void ChangeSaveButtonMode(bool aux)
        {
           btnGenerate.Enabled = aux;
        }
    }
}