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
    public partial class PasajerosxVuelo : Form
    {
        public PasajerosxVuelo()
        {
            InitializeComponent();
        }

        private void PasajerosxVuelo_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
           
            cbVuelos.DataSource = dt;
            cbVuelos.ValueMember = "IdVuelo";
            cbVuelos.DisplayMember = "IdVuelo";
            cbVuelos.SelectedIndex = -1;
        }

        private void btnFiltrarAviones_Click(object sender, EventArgs e)
        {
            string destino="";
            string Aeropuerto="";

            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "select LugarDestino, Aeropuerto from destinos inner join Vuelos on Vuelos.IdDestino = Destinos.IdDestino where IdVuelo = '"+ cbVuelos.Text.Trim() + "'";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                destino = dr["LugarDestino"].ToString().Trim();
                Aeropuerto = dr["Aeropuerto"].ToString().Trim();
            }
            cn.Close();

            
            label2.Text = "El Vuelo con ID " + cbVuelos.Text.Trim() + " con destino a " + destino + " tiene los siguientes pasajeros:";

            string consultar = " select distinct Pasajeros.IdPasajero,Nombre,Apellido,Dni from Pasajeros inner join detalle_Pagos on Detalle_Pagos.IdPasajero = Pasajeros.IdPasajero where Detalle_Pagos.IdVuelo = '" + cbVuelos.Text.Trim() + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Detalle_Pagos");
            dgvVuelos.DataSource = dt;


        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            cbVuelos.SelectedIndex = -1;
            string consultar = " select distinct Pasajeros.IdPasajero,Nombre,Apellido,Dni from Pasajeros inner join detalle_Pagos on Detalle_Pagos.IdPasajero = Pasajeros.IdPasajero where Detalle_Pagos.IdVuelo = '" + cbVuelos.Text.Trim() + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Detalle_Pagos");
            dgvVuelos.DataSource = dt;
        }
    }
}
