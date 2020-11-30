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
    public partial class RealizarCompra : Form
    {
        public RealizarCompra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RealizarCompra_Load(object sender, EventArgs e)
        {
            lblCapacidad.Visible = false;
            txtCapacidad.Visible = false;
            string consulta = "select * from Pasajeros";
            string consultar = "Select * from Vuelos";
            string con = "Select * from Clases";

            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
            DataTable data = ConexionTabla.devuelveTabla(consultar,"Vuelos");
            DataTable dat = ConexionTabla.devuelveTabla (con,"Clases");

            cbPasajero.DataSource = dt;
            cbPasajero.ValueMember = "IdPasajero";
            cbPasajero.DisplayMember = "IdPasajero";
            cbPasajero.SelectedIndex = -1;

            cbVuelo.DataSource = data;
            cbVuelo.ValueMember = "IdVuelo";
            cbVuelo.DisplayMember = "IdVuelo";
            cbVuelo.SelectedIndex = -1;

            cbClase.DataSource = dat;
            cbClase.ValueMember = "ImporteClase";
            cbClase.DisplayMember = "NombreClase";
            cbClase.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbIdPago.Text = "";
            tbMontoTotal.Text = "";
            cbClase.SelectedIndex = -1;
            cbPasajero.SelectedIndex = -1;
            cbVuelo.SelectedIndex = -1;
            dateTimePicker1.Text = DateTime.Today.ToString();
            lblCapacidad.Visible = false;
            txtCapacidad.Visible = false;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            int capacidad = 0;
            int Vendidos = 0;

            if (cbVuelo.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Realizar Pagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = rutaSQL;
                SqlCommand comando = new SqlCommand();
                //comando.CommandText = "select capacidad from aviones inner join Vuelos on vuelos.IdAvion = Aviones.IdAvion inner join Detalle_Pagos on Detalle_Pagos.IdVuelo = Vuelos.IdVuelo where Detalle_Pagos.IdVuelo = '" + cbVuelo.Text.Trim() + "'";
                comando.CommandText = "select * from Aviones inner join Vuelos on vuelos.IdAvion = Aviones.IdAvion where Vuelos.IdVuelo = '" + cbVuelo.Text.Trim() + "'";
                comando.Connection = cn;
                cn.Open();

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read() == true)
                {
                    int.TryParse(dr["Capacidad"].ToString(), out capacidad);
                }
                cn.Close();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = rutaSQL;
                SqlCommand comand = new SqlCommand();
                comand.CommandText = "select count(*)as Ventas from Detalle_Pagos inner join Vuelos on vuelos.IdVuelo = Detalle_Pagos.IdVuelo where Detalle_Pagos.IdVuelo = '" + cbVuelo.Text.Trim() + "'";
                comand.Connection = con;
                con.Open();

                SqlDataReader d = comand.ExecuteReader();
                while (d.Read() == true)
                {
                    int.TryParse(d["Ventas"].ToString(), out Vendidos);
                }
                con.Close();
            }
            if (tbIdPago.Text.Trim() == "" || cbClase.Text.Trim() == "" || cbVuelo.Text.Trim() == "" || cbPasajero.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Realizar Pagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else  if(capacidad==Vendidos)
            {
                MessageBox.Show("El vuelo ya esta vendido por completo", "Realizar Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            }
            else
            {

                bool estado;

                DatosDetallePago DetallePago = new DatosDetallePago();

                DetallePago.IdPago = tbIdPago.Text;
                DetallePago.IdClase = cbClase.Text.Trim().ToString().Substring(0, 3);
                DetallePago.IdVuelo = cbVuelo.Text.Trim().ToString();
                DetallePago.IdPasajero = cbPasajero.SelectedValue.ToString();
                DetallePago.Monto = tbMontoTotal.Text;


                GestionarDetallePago gDetallePagos = new GestionarDetallePago();
                estado = gDetallePagos.Insertar(DetallePago);

                DatosPagos Pago = new DatosPagos();

                Pago.IdPago = tbIdPago.Text;
                Pago.Cliente = cbPasajero.SelectedValue.ToString();
                Pago.Total = Convert.ToInt32(tbMontoTotal.Text);


                GestionarPagos gPagos = new GestionarPagos();
                estado = gPagos.Insertar(Pago);


                if (estado)
                {
                    MessageBox.Show("El pago fue agregado con exito");
                    //ActualizarGrilla();
                    //LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el pago");
                }
            }
        }

        private void cbVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Vuelos where IdVuelo = '" +  cbVuelo.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                dateTimePicker1.Text = dr["FechaVuelo"].ToString();
                tbMontoTotal.Text = Convert.ToInt32(dr["MontoVuelo"]).ToString();
            }

            SqlCommand cmd2;
            SqlDataReader dr2;
            SqlCommand cmd3;
            SqlDataReader dr3;
            Conexion cnn = new Conexion();

            //cmd3 = new SqlCommand("select Capacidad from Aviones inner join Vuelos on Vuelos.idavion = Aviones.IdAvion where Vuelos.idavion = Aviones.IdAvion", cnn.ObtenerConexion());
            //cmd2 = new SqlCommand("select count(*) as Ventas from Detalle_Pagos inner join Vuelos on Vuelos.IdVuelo = Detalle_Pagos.IdVuelo where Detalle_Pagos.IdVuelo = '" + cbVuelo.SelectedItem + "'", cnn.ObtenerConexion());
            //dr2 = cmd2.ExecuteReader();
            //dr3 = cmd3.ExecuteReader();

            //while (dr2.Read() && dr3.Read())
            //{
            //    txtCapacidad.Text = Convert.ToString(Convert.ToInt32(dr3["Capacidad"]) - Convert.ToInt32(dr2["Ventas"]));
            //}
            lblCapacidad.Visible = true;
            txtCapacidad.Visible = true;
            cn.Close();
        }

        private void cbClase_SelectedValueChanged(object sender, EventArgs e)
        {
            float importe = 0;
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            SqlConnection conection = new SqlConnection();
          
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Vuelos where IdVuelo = '" + cbVuelo.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                float.TryParse(dr["MontoVuelo"].ToString(), out importe);
            }
            cn.Close();

            float cls= 0;
            if(cbClase.SelectedIndex ==-1)
            {
               tbMontoTotal.Text = "";
            }
            else
            {
                float.TryParse(cbClase.SelectedValue.ToString(), out cls);
                float total;
                total = (importe * cls);
                tbMontoTotal.Text = total.ToString();

            }
            
        }
    }
}
