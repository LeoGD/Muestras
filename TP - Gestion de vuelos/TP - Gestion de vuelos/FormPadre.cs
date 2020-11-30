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
    public partial class FormPadre : Form
    {
        public FormPadre()
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            NuevoElemento frm = new NuevoElemento();
            abrirFormularioHijo(frm);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            EliminarElemento frm = new EliminarElemento();
            abrirFormularioHijo(frm);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ModificarElemento frm = new ModificarElemento();
            abrirFormularioHijo(frm);
        }

        private void realizarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            RealizarCompra frm = new RealizarCompra();
            abrirFormularioHijo(frm);
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {

        }

        private void verElManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:Manual del usuario.pdf";
            proc.Start();
        }

        private void pasajerosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ListadoPasajeros frm = new ListadoPasajeros();
            abrirFormularioHijo(frm);
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ListadoVuelos frm = new ListadoVuelos();
            abrirFormularioHijo(frm);
        }

        private void avionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ListadoAviones frm = new ListadoAviones();
            abrirFormularioHijo(frm);
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ListadoDestinos frm = new ListadoDestinos();
            abrirFormularioHijo(frm);
        }

        private void pagosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            PagosRealizados frm = new PagosRealizados();
            abrirFormularioHijo(frm);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Salir del programa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).ToString().Contains("Yes"))
            {
                Application.Exit();
            }   
        }

        private void modificarPorcentajeDeLaClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            PorcentajeClase frm = new PorcentajeClase();
            abrirFormularioHijo(frm);
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            ImporteDestino frm = new ImporteDestino();
            abrirFormularioHijo(frm);
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            Integrantes frm = new Integrantes();
            abrirFormularioHijo(frm);
        }

        private void pasajerosDeUnVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            PasajerosxVuelo frm = new PasajerosxVuelo();
            abrirFormularioHijo(frm);
        }

        private void recaudaciónDeUnVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            Recaudaciones frm = new Recaudaciones();
            abrirFormularioHijo(frm);
        }

        private void ocupaciónDeAvionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularioHijo();
            Ocupacion frm = new Ocupacion();
            abrirFormularioHijo(frm);
        }

    }
}
