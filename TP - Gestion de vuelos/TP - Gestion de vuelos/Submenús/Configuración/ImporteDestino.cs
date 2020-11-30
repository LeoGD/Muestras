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
    public partial class ImporteDestino : Form
    {
        public ImporteDestino()
        {
            InitializeComponent();
        }

        private void ImporteDestino_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Destinos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");
            cbDestino.DataSource = dt;
            cbDestino.ValueMember = "IdDestino";
            cbDestino.DisplayMember = "IdDestino";
            cbDestino.SelectedIndex = -1;
            tbImporteActual.Text = "Importe Actual";
            tbImporteNuevo.Text = "Importe Nuevo";
           

           
        }

        private void tbImporteNuevo_KeyPress(object sender, KeyPressEventArgs e)
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
                tbImporteActual.Text = dr["ImporteDestino"].ToString();
                tbImporteNuevo.Text = "";
            }
            cn.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbImporteNuevo.Text.Trim() == "")
            {
                MessageBox.Show("No se estableció nuevo importe", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";
                string consulta = "Update Destinos set ImporteDestino = '" + tbImporteNuevo.Text.Trim() + "' where IdDestino = '" + cbDestino.SelectedValue + "'";
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = rutaSQL;
                SqlCommand comando = new SqlCommand();
                comando.CommandText = consulta;
                comando.Connection = cn;
                cn.Open();

                SqlDataReader dr = comando.ExecuteReader();

                MessageBox.Show("El importe se ha modificado con éxito", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                cn.Close();
            }
            cbDestino.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
