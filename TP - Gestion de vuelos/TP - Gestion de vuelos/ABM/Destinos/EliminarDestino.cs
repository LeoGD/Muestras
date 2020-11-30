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
    public partial class EliminarDestino : Form
    {
        public EliminarDestino()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarDestino_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Destinos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdDestino";
            cbID.ValueMember = "IdDestino";
            cbID.SelectedIndex = -1;
            txtImporte.Text = "Importe Destino";
            txtIdPais.Text = "ID Pais";
            txtDestino.Text = "Destino";
            txtAeropuerto.Text = "Aeropuerto";
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Destinos where IdDestino = '" + cbID.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txtIdPais.Text = dr["IdPais"].ToString();
                txtDestino.Text = dr["LugarDestino"].ToString();
                txtAeropuerto.Text = dr["Aeropuerto"].ToString();
                txtImporte.Text = dr["ImporteDestino"].ToString();
            }
            cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Importe;
            int.TryParse(this.txtImporte.Text.Trim(),out Importe);
            NDestino.Eliminar(this.cbID.Text.Trim().ToString(), this.txtDestino.Text.Trim().ToString(),
                this.txtIdPais.Text.Trim().ToString(), this.txtAeropuerto.Text.Trim().ToString(), Importe);
            MessageBox.Show("Registro eliminado correctamente", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpiar();
            cbID.Focus();
            string consulta = "select * from Destinos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdDestino";
            cbID.ValueMember = "IdDestino";
            cbID.SelectedIndex = -1;
            txtImporte.Text = "Importe Destino";
            txtIdPais.Text = "ID Pais";
            txtDestino.Text = "Destino";
            txtAeropuerto.Text = "Aeropuerto";
        }
    }
}
