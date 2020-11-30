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
    public partial class EliminarElemento : Form
    {
        public EliminarElemento()
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

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            EliminarPasajero frm = new EliminarPasajero();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            EliminarDestino frm = new EliminarDestino();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            EliminarVuelo frm = new EliminarVuelo();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
