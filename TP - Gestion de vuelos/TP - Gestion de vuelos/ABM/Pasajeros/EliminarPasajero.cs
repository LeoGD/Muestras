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
    public partial class EliminarPasajero : Form
    {
        public EliminarPasajero()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NPasajero.Eliminar(this.cbID.Text.Trim(), this.txtDNI.Text.Trim(), this.txtPasaporte.Text.Trim(),
                this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.dtpFecha.Value,
                this.txtNac.Text.Trim(), this.txtTelefono.Text.Trim(), this.txtMail.Text.Trim());

            MessageBox.Show("Registro eliminado correctamente", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            cbID.Focus();

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

        private void EliminarPasajero_Load(object sender, EventArgs e)
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
