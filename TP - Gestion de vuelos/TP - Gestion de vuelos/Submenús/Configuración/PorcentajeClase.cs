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
    public partial class PorcentajeClase : Form
    {
        public PorcentajeClase()
        {
            InitializeComponent();
        }

        private void PorcentajeClase_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Clases";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Clases");
            cbClase.DataSource = dt;
            cbClase.ValueMember = "IdClase";
            cbClase.DisplayMember = "NombreClase";
            cbClase.SelectedIndex = -1;
            tbNuevoPorcentaje.Text = "Nuevo Porcentaje";
            tbPorcentajeActual.Text = "Porcentaje Actual";
        }

        private void tbNuevoPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void cbClase_SelectedValueChanged(object sender, EventArgs e)
        {
            string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = rutaSQL;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from Clases where IdClase = '" + cbClase.SelectedValue + "'";
            comando.Connection = cn;
            cn.Open();

            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                tbPorcentajeActual.Text = dr["ImporteClase"].ToString();
                tbNuevoPorcentaje.Text = "";
            }
            cn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbNuevoPorcentaje.Text.Trim() == "")
            {
                MessageBox.Show("No se estableció nuevo porcentaje", "Clases", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string rutaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=DELESMAR_db;Integrated Security=True";
                string consulta = "Update Clases set ImporteClase = '" + tbNuevoPorcentaje.Text.Trim() + "' where IdClase = '" + cbClase.SelectedValue + "'";
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = rutaSQL;
                SqlCommand comando = new SqlCommand();
                comando.CommandText = consulta;
                comando.Connection = cn;
                cn.Open();

                SqlDataReader dr = comando.ExecuteReader();

                MessageBox.Show("El porcentaje se ha modificado con éxito", "Clases", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                cn.Close();
            }
            cbClase.SelectedIndex = -1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
