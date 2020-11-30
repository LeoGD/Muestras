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
        Form frmAnterior = new Form();
        public AgregarPasajero(Form frm2)
        {
            frmAnterior = frm2;
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
           // cerrarFormularioHijo();
           // frmAnterior.Close();
            this.Close();
           
            //FormPadre frm = new FormPadre();
            //frm.Show();
            
            
            //form.Hide();
          
            
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string consulta = "Select IdPasajero from Pasajeros where IdPasajero = '" + txtID.Text + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Existe un IdPasajero " + txtID.Text + " en la base de datos", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtApellido.Text.Trim() == "" || txtDNI.Text.Trim() == "" || txtNac.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtTelefono.Text.Trim() == "" ||  dtpFecha.Text.Trim() == "" || txtMail.Text.Trim() == "" || txtID.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("Fecha invalida", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool estado;

                DatosPasajeros pasajero = new DatosPasajeros();
                pasajero.IdPasajero = txtID.Text;
                pasajero.DNI = txtDNI.Text;
                pasajero.Pasaporte = txtPasaporte.Text;
                pasajero.Nombre = txtNombre.Text;
                pasajero.Apellido = txtApellido.Text;
                pasajero.FechaNac = dtpFecha.Value;
                pasajero.Nacionalidad = txtNac.Text;
                pasajero.Telefono = txtTelefono.Text;
                pasajero.Mail = txtMail.Text;

                GestionarPasajeros gpasajero = new GestionarPasajeros();
                estado = gpasajero.Insertar(pasajero);

                if (estado)
                {
                    MessageBox.Show("El pasajero fue agregado con exito");
                    //ActualizarGrilla();
                    //LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el pasajero");
                }
            }
        }

        private void Limpiar()
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPasaporte.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtNac.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            dtpFecha.Text = DateTime.Today.ToString();
          
        }
    }
}
