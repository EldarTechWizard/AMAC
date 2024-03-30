using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAC.Views.RecordManagement
{
    public partial class RecordManagementView : DevExpress.XtraEditors.XtraForm, IRecordManagementView
    {
        public DataTable DataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FilterText => throw new NotImplementedException();

        public RecordManagementView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();

        }

        public event EventHandler OnClickUpdateRecordPictureEdit;
        public event EventHandler OnClickDeleteRecordPictureEdit;
        public event EventHandler OnClickSearchRecordPictureEdit;
        public event EventHandler OnClickLoadRecordsPictureEdit;

        private void AssociateAndRaisedEvents()
        {
         
        }


        private void pbEditar_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            label5.Text = "EDITAR REGISTRO";
            dgvRecords.ReadOnly = false;
        }

        private void pbBorrar_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown;
            label5.Text = "ELIMINAR REGISTRO";
        }

        private void pbConsultar_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MidnightBlue;
            label5.Text = "CONSULTAR INFORMACION";
            dgvRecords.ReadOnly = true;
        }

        public void ChangeActiveHeader()
        {
            throw new NotImplementedException();
        }
    }
}