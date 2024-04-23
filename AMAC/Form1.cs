using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbManagmentAMAC.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace AMAC
{
    public partial class Form1 : Form
    {

        private IRepository repository;
        public Form1(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            //repository.SelectPdfFormat(dt);
           // lookUpEdit1.Properties.DataSource = dt;


            repository.SelectAdopter(dt);

            gridControl1.DataSource = dt;


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
