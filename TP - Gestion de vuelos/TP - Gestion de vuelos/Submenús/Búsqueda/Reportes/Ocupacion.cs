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
    public partial class Ocupacion : Form
    {
        public Ocupacion()
        {
            InitializeComponent();
        }

        private void Ocupacion_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.ObtenerConexion();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("select * from Aviones", cn.ObtenerConexion());
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lbAviones.Items.Add(dr["IdAvion"].ToString());
            }
            dr.Close();
        }

        private void lbAviones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion cnn = new Conexion();
            cnn.ObtenerConexion();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("select Capacidad from Aviones where IdAvion = '" + lbAviones.SelectedItem + "'", cnn.ObtenerConexion());
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCapacidad.Text = dr["Capacidad"].ToString();
            }
            dr.Close();

            SqlCommand cmd1;
            SqlDataReader dr1;
            Conexion cn = new Conexion();
            cmd1 = new SqlCommand("select * from Vuelos inner join Aviones on Vuelos.IdAvion = Aviones.IdAvion where Vuelos.IdAvion = '" + lbAviones.SelectedItem + "'", cn.ObtenerConexion());
            dr1 = cmd1.ExecuteReader();
            lbVuelos.Items.Clear();

            while (dr1.Read())
            {
                if (dr1["IdVuelo"].ToString() == null)
                {
                    lbVuelos.Items.Clear();
                }
                else
                {
                    lbVuelos.Items.Add(dr1["IdVuelo"].ToString());
                }
            }
            dr1.Close();
        }

        private void lbVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("select count(*) as Ventas from Detalle_Pagos inner join Vuelos on Vuelos.IdVuelo = Detalle_Pagos.IdVuelo where Detalle_Pagos.IdVuelo = '" + lbVuelos.SelectedItem + "'",cn.ObtenerConexion());
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                txtAsientos.Text = dr["Ventas"].ToString();
            }

            txtPorcentaje.Text = Convert.ToString(Math.Round((100 - Convert.ToDouble(txtAsientos.Text) * 100 / Convert.ToDouble(txtCapacidad.Text)),2)) + '%';
            dr.Close();
        }
    }
}
