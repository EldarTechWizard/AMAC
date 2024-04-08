using AMAC.Presenters;
using AMAC.Views.FormatManagement.FormatControls.FormatAnimalView;
using AMAC.Views.FormatManagement.SearchTableView;
using DbManagmentAMAC.Models;
using DevExpress.ClipboardSource.SpreadsheetML;
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

namespace AMAC.Views.FormatManagement.FormatControls.FormatAdopterView
{
    public partial class FormatAdopterView : DevExpress.XtraEditors.XtraForm , IFormatAdopterView
    {
        public int Id
        {
            get
            {
                int value = 0;

                if (int.TryParse(tbAdopterlId.Text, out value))
                {
                    return value;
                }

                return -1;
            }

            set => tbAdopterlId.Text = value.ToString();
        }
        public string NameA { get => tbName.Text; set => tbName.Text = value; }
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
        public string Address { get => tbAddress.Text; set => tbAddress.Text = value; }
        public string Email { get => tbEmail.Text; set => tbEmail.Text = value; }
        public string Number { get => tbNumber.Text; set => tbNumber.Text = value; }


        public FormatAdopterView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }

        public event EventHandler OnChangeAdopterIdTextBox;
        public event EventHandler OnClickSearchAdopterPictureEdit;

        private void AssociateAndRaisedEvents()
        {
            tbAdopterlId.TextChanged += delegate { OnChangeAdopterIdTextBox.Invoke(tbAdopterlId, EventArgs.Empty); };
            peSeachAdopter.Click += delegate { OnClickSearchAdopterPictureEdit.Invoke(peSeachAdopter, EventArgs.Empty); };
        }

        public void ClearAdopterFields()
        {
            tbName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbAge.Text = string.Empty;
            tbNumber.Text = string.Empty;
            tbEmail.Text = string.Empty;
        }

        public DataRow OpenSearchTableTab(DataTable data)
        {
            ISearchTableView view = new SearchTableView.SearchTableView();
            new SearchTablePresenter(view, data);
            Form temp = (Form)view;
            temp.ShowDialog();

            return view.DataRow;
        }

        public Adopter GetAdopter()
        {
            Adopter adopter = new Adopter()
            {
                Id = this.Id,
                Name = this.NameA,
                Age = this.Age,
                Address = this.Address,
                Email = this.Email,
                Number = this.Number,
            };

            return adopter;
        }
    }
}