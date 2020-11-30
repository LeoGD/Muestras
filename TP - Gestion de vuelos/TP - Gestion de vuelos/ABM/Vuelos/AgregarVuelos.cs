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
    public partial class AgregarVuelos : Form
    {
        public AgregarVuelos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
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
            string consulta = "Select IdVuelo from Vuelos where IdVuelo = '" + txtIDVuelo.Text + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Existe un IdVuelo " + txtIDVuelo.Text + " en la base de datos", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtIDVuelo.Text.Trim() == "" || cbAvion.Text.Trim() == "" || cbDestino.Text.Trim() == "" || txtMonto.Text.Trim() == "" || dtpFechaVuelo.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Existen campos sin completar", "Vuelos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                bool estado;

                DatosVuelos Vuelo = new DatosVuelos();
                Vuelo.IdVuelo = txtIDVuelo.Text.Trim().ToString();
                Vuelo.IdAvion = cbAvion.Text.Trim().ToString();
                Vuelo.IdDestino = cbDestino.SelectedValue.ToString();
                Vuelo.FechaVuelo = dtpFechaVuelo.Value.Date;
                Vuelo.MontoVuelo = Convert.ToInt32(txtMonto.Text.Trim().ToString());

                GestionarVuelos gVuelo = new GestionarVuelos();
                estado = gVuelo.Insertar(Vuelo);


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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDVuelo.Text = "";
            txtMonto.Text = "";
            cbDestino.SelectedIndex = -1;
            cbAvion.SelectedIndex = -1 ;
            dtpFechaVuelo.Text = DateTime.Today.ToString();
        }

        private void AgregarVuelos_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Destinos order by LugarDestino asc";
            string con = "Select * from Aviones";
            DataTable data = ConexionTabla.devuelveTabla(con, "Aviones");
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");
            cbDestino.DataSource = dt;
            cbDestino.ValueMember = "IdDestino";
            cbDestino.DisplayMember = "LugarDestino";
            cbDestino.SelectedIndex = -1;
            cbAvion.DataSource = data;
            cbAvion.ValueMember = "IdAvion";
            cbAvion.DisplayMember = "IdAvion";
            cbAvion.SelectedIndex = -1;
            
        }

        private void cbDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Destinos where IdDestino = '" + cbDestino.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                txtMonto.Text = Convert.ToInt32(dr["ImporteDestino"]).ToString();
            }

            cn.Close();
            if (cbDestino.SelectedIndex == -1)
            {
                txtMonto.Text = "";
            }

        }
    }
}
