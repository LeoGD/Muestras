using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    public partial class ModificarPasajero : Form
    {
        public ModificarPasajero()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "" || txtDNI.Text.Trim() == "" || txtNac.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || dtpFecha.Text.Trim() == "" || txtMail.Text.Trim() == "" || cbID.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool estado;

                DatosPasajeros pasajero = new DatosPasajeros();
                pasajero.IdPasajero = cbID.Text;
                pasajero.DNI = txtDNI.Text;
                pasajero.Pasaporte = txtPasaporte.Text;
                pasajero.Nombre = txtNombre.Text;
                pasajero.Apellido = txtApellido.Text;
                pasajero.FechaNac = dtpFecha.Value.Date;
                pasajero.Nacionalidad = txtNac.Text;
                pasajero.Telefono = txtTelefono.Text;
                pasajero.Mail = txtMail.Text;

                GestionarPasajeros gpasajero = new GestionarPasajeros();
                estado = gpasajero.Modificar(pasajero);

                if (estado)
                {
                    MessageBox.Show("Registro modificado correctamente", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el pasajero", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string consulta = "select * from Pasajeros";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdPasajero";
            cbID.ValueMember = "IdPasajero";
            cbID.SelectedIndex = -1;

            txtApellido.Text = "Apellido";
            txtDNI.Text = "Dni";
            txtNombre.Text = "Nombre";
            txtPasaporte.Text = "Pasaporte";
            txtMail.Text = "Mail";
            txtNac.Text = "Nacionalidad";
            txtTelefono.Text = "Teléfono";
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            /// Agregar validacion y que se carguen solo los datos en los
            /// textbox correspondiente al ID Pasajero elegido
            string consulta = "select * from Pasajeros";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdPasajero";
            cbID.ValueMember = "IdPasajero";
            cbID.SelectedIndex = -1;

            txtApellido.Text = "Apellido";
            txtDNI.Text = "Dni";
            txtNombre.Text = "Nombre";
            txtPasaporte.Text = "Pasaporte";
            txtMail.Text = "Mail";
            txtNac.Text = "Nacionalidad";
            txtTelefono.Text = "Teléfono";
        

        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Pasajeros where IdPasajero = '" + cbID.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txtPasaporte.Text = dr["Pasaporte"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtApellido.Text = dr["Apellido"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtDNI.Text = dr["Dni"].ToString();
                txtNac.Text = dr["Nacionalidad"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                dtpFecha.Text = dr["FechaNac"].ToString();

            }
            cn.Close();
        }
    }
}
