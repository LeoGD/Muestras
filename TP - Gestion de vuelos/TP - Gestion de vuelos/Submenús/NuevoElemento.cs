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
    public partial class NuevoElemento : Form
    {
        public NuevoElemento()
        {
            InitializeComponent();
        }
        private void NuevoElemento_Load(object sender, EventArgs e)
        {

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

        public void button1_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            AgregarPasajero frm = new AgregarPasajero();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            AgregarDestino frm = new AgregarDestino();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            AgregarVuelos frm = new AgregarVuelos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
