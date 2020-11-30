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
    public partial class EliminarVuelo : Form
    {
        public EliminarVuelo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarVuelo_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdVuelo";
            cbID.ValueMember = "IdVuelo";
            cbID.SelectedIndex = -1;
            txtIdAvion.Text = "ID Avion";
            txtIdDestino.Text = "Destino";
            txtMonto.Text = "Monto Vuelo";    
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Vuelos where IdVuelo = '" + cbID.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txtIdAvion.Text = dr["IdAvion"].ToString();
                txtIdDestino.Text = dr["IdDestino"].ToString();
                txtMonto.Text = dr["MontoVuelo"].ToString();
                dateTimePicker1.Value =  Convert.ToDateTime(dr["FechaVuelo"].ToString());
            }
            cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int Importe;
            int.TryParse(this.txtMonto.Text.Trim(), out Importe);
            NVuelo.Eliminar(this.cbID.Text.Trim().ToString(),this.txtIdDestino.Text.Trim().ToString(),this.txtIdAvion.Text.Trim().ToString(),
               this.dateTimePicker1.Value.Date, Importe);
            
            MessageBox.Show("Registro eliminado correctamente", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpiar();
            cbID.Focus();
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");

            cbID.DataSource = dt;
            cbID.DisplayMember = "IdVuelo";
            cbID.ValueMember = "IdVuelo";
            cbID.SelectedIndex = -1;
            txtIdAvion.Text = "ID Avion";
            txtIdDestino.Text = "Destino";
            txtMonto.Text = "Monto Vuelo"; 
        }
    }
}
