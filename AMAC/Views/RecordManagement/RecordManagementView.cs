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

namespace DiseñoAMAC
{
    public partial class consultarRegistro : DevExpress.XtraEditors.XtraForm
    {
        public consultarRegistro()
        {
            InitializeComponent();

        }

  

        private void pbEditar_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            label5.Text = "EDITAR REGISTRO";
            dgvRegistros.ReadOnly = false;
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
            dgvRegistros.ReadOnly = true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbEditar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pbConsultar_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}