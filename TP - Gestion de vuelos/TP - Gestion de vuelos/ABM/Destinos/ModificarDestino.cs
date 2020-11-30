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
    public partial class ModificarDestino : Form
    {
        public ModificarDestino()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarDestino_Load(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbID.Text.Trim() == "" || txtDestino.Text.Trim() == "" || txtAeropuerto.Text.Trim() == "" || txtImporte.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool estado;


                DatosDestinos Destino = new DatosDestinos();
                Destino.IdDestino = cbID.Text.Trim();
                Destino.IdPais = txtIdPais.Text.ToString();
                Destino.LugarDestino = txtDestino.Text.Trim();
                Destino.Aeropuerto = txtAeropuerto.Text.Trim();
                Destino.ImporteDestino = Convert.ToInt32(txtImporte.Text.Trim());

                GestionarDestinos gDestino = new GestionarDestinos();
                estado = gDestino.Modificar(Destino);

                if (estado)
                {
                    MessageBox.Show("Registro modificado correctamente", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el destino", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               
        }

        private void cbID_SelectedValueChanged(object sender, EventArgs e)
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

        
    }
}
