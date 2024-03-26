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

namespace DiseñoAMAC
{
    public partial class generarFormato : DevExpress.XtraEditors.XtraForm
    {
        public generarFormato()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form currentChildForm;


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            childForm.TopLevel = false;
            currentChildForm = childForm;
            panelventana.Controls.Add(currentChildForm);
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelventana.Controls.Clear();
            OpenChildForm(new crearFormato());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelventana.Controls.Clear();
            ModificarDoc userControl1 = new ModificarDoc();
            // Suscribirse al evento SizeChanged del panel
            panelventana.SizeChanged += (s, ev) =>
            {
                userControl1.Size = panelventana.Size;
            };
            panelventana.Controls.Add(userControl1);
        }
    }
}