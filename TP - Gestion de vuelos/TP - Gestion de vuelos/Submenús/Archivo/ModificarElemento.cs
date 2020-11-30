using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP___Gestion_de_vuelos
{
    public partial class ModificarElemento : Form
    {
        public ModificarElemento()
        {
            InitializeComponent();
        }

        public void abrirFormularioHijo(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        public void cerrarFormularioHijo()
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ModificarPasajero frm = new ModificarPasajero();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ModificarDestino frm = new ModificarDestino();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ModificarVuelo frm = new ModificarVuelo();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
