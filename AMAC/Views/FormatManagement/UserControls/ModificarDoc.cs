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
    public partial class ModificarDoc : UserControl
    {
        public ModificarDoc()
        {
            InitializeComponent();
            this.SizeChanged += UserControl1_SizeChanged;

        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {

        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Size = this.Parent.Size;
                this.Location = new System.Drawing.Point(0, 0);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }


        private void btDatosMascota_Click(object sender, EventArgs e)
        {
            panelmodificar.Controls.Clear();
            ModificarDoc_Animal modificarDoc_Animal = new ModificarDoc_Animal();
            panelmodificar.Controls.Add(modificarDoc_Animal);
        }

        private void btDatosAdopt_Click(object sender, EventArgs e)
        {
            panelmodificar.Controls.Clear();
            ModificarDoc_Adopt modificarDoc_Adopt = new ModificarDoc_Adopt();
            panelmodificar.Controls.Add(modificarDoc_Adopt);
        }

        private void btRespons_Click(object sender, EventArgs e)
        {
            panelmodificar.Controls.Clear();
            ModificarDoc_Resp modificarDoc_Resp = new ModificarDoc_Resp();
            panelmodificar.Controls.Add(modificarDoc_Resp);
        }
    }
}
