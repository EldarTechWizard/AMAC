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
    public partial class ModificarDoc_Animal : UserControl
    {
        public ModificarDoc_Animal()
        {
            InitializeComponent();
        }

        private void ModificarDoc_Animal_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Size = this.Parent.Size;
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}
