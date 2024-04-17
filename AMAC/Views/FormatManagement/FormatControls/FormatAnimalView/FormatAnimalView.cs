using AMAC.Presenters;
using AMAC.Views.FormatManagement.SearchTableView;
using DbManagmentAMAC.Models;
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

namespace AMAC.Views.FormatManagement.FormatControls.FormatAnimalView
{
    public partial class FormatAnimalView : DevExpress.XtraEditors.XtraForm, IFormatAnimalView
    {

        public int Id
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbId.Text, out value))
                {
                    return value;
                }

                return -1;
            }

            set => tbId.Text = value.ToString();
        }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
        public string AnimalType { get => tbAnimalType.Text; set => tbAnimalType.Text = value; }
        public string AnimalBreed { get => tbAnimalBreed.Text; set => tbAnimalBreed.Text = value; }
        public string Sex { get => tbSex.Text; set => tbSex.Text = value; }
        public bool Sterilized { get => chbSterilized.Checked; set => chbSterilized.Checked = value; }
        public string AdditionalInformation { get => tbAdditionalInformation.Text; set => tbAdditionalInformation.Text = value; }
        public int Age
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbAge.Text, out value))
                {
                    return value;
                }

                return -1;
            }
            set => tbAge.Text = value.ToString();
        }
        public string Status { get => tbStatus.Text; set => tbStatus.Text = value; }

        public event EventHandler OnChangeAdopterIdTextBox;
        public event EventHandler OnClickSearchAdopterPictureEdit;

        public FormatAnimalView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            tbId.TextChanged += delegate { OnChangeAdopterIdTextBox.Invoke(tbId, EventArgs.Empty); };
            peSeachAnimal.Click += delegate { OnClickSearchAdopterPictureEdit.Invoke(peSeachAnimal, EventArgs.Empty); };
        }

       

        public DataRow OpenSearchTableTab(DataTable data)
        {
            ISearchTableView view = new SearchTableView.SearchTableView();
            new SearchTablePresenter(view, data);
            Form temp = (Form)view;
            temp.ShowDialog();

            return view.DataRow;
        }

        public void ClearAnimalFields()
        {
            tbAnimalType.Text = string.Empty;
            tbName.Text = string.Empty;
            tbSex.Text = string.Empty;
            tbAnimalBreed.Text = string.Empty;
            tbAnimalType.Text = string.Empty;
            tbStatus.Text = string.Empty;
            tbAge.Text = string.Empty;
            tbAdditionalInformation.Text = string.Empty;
        }

        public Animal GetAnimal()
        {
            Animal animal = new Animal()
            {
                Id = this.Id,
                Name = this.NameA,
                Age = this.Age,
                Sex = this.Sex,
                AnimalType = this.AnimalType,
                AnimalBreed = this.AnimalBreed,
                Status = this.Status,
                Sterilized = this.Sterilized,
                AdditionalInformation = this.AdditionalInformation,
            };

            return animal;
        }

  
    }
}