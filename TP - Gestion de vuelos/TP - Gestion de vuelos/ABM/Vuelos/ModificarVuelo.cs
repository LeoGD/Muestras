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
    public partial class ModificarVuelo : Form
    {
        public ModificarVuelo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarVuelo_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
            cbID.DataSource = dt;
            cbID.ValueMember = "IdVuelo";
            cbID.DisplayMember = "IdVuelo";
            cbID.SelectedIndex = -1;

            txtMonto.Text = "Monto Vuelo";
            txtAvion.Text = "ID Avión";
        }

        private void cbID_SelectedValueChanged(object sender, EventArgs e)
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
                txtAvion.Text = dr["IdAvion"].ToString();
                txtMonto.Text = dr["MontoVuelo"].ToString();
                dateTimePicker1.Text = dr["FechaVuelo"].ToString();
            }
            cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbID.Text.Trim() == "" || txtAvion.Text.Trim() == "" || txtMonto.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                bool estado;

                DatosVuelos Vuelo = new DatosVuelos();
                Vuelo.IdVuelo = cbID.Text.Trim().ToString();
                Vuelo.IdAvion = txtAvion.Text.Trim().ToString();
                Vuelo.FechaVuelo = dateTimePicker1.Value.Date;
                //Vuelo.MontoVuelo = Convert.ToInt32(txtMonto.Text.Trim().ToString());

                GestionarVuelos gVuelo = new GestionarVuelos();
                estado = gVuelo.Modificar(Vuelo);


                if (estado)
                {
                    MessageBox.Show("El vuelo fue agregado con exito");
                    //ActualizarGrilla();
                    //LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el vuelo");
                }
            }
        }
    }
}
