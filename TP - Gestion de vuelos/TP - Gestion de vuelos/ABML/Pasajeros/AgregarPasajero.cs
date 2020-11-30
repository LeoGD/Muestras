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
    public partial class AgregarPasajero : Form
    {
        public AgregarPasajero()
        {
            InitializeComponent();
        }

        private void AgregarPasajero_Load(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cerrarFormularioHijo();
            NuevoElemento form = new NuevoElemento();
            form.Hide();
            this.Close();
            FormPadre frm = new FormPadre();
            frm.Show();

             //NuevoElemento form = new NuevoElemento();
            //form.Close();
            //form.Hide();
          
            
        }
    }
}
