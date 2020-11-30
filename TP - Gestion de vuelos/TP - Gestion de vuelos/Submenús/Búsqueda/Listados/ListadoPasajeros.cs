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
using System.Configuration;

namespace TP___Gestion_de_vuelos
{
    public partial class ListadoPasajeros : Form
    {
        public ListadoPasajeros()
        {
            InitializeComponent();
        }

        private void ListadoPasajeros_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Pasajeros";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");

            dgvPasajeros.DataSource = dt;
            dgvDniPasajero.DataSource = dt;
            dgvApellidos.DataSource = dt;

            cbPasajeros.DataSource = dt;
            cbPasajeros.ValueMember = "IdPasajero";
            cbPasajeros.DisplayMember = "IdPasajero";
            cbPasajeros.SelectedIndex = -1;
            cbDniPasajero.DataSource = dt;
            cbDniPasajero.ValueMember = "Dni";
            cbDniPasajero.DisplayMember = "Dni";
            cbDniPasajero.SelectedIndex = -1;

            /// AUTOCOMPLETAR
            Conexion c = new Conexion();
            c.autoCompletar(txtIdPasajero);
        }

        private void btnFiltrarPasajeros_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Pasajeros where IdPasajero = '" + txtIdPasajero.Text.ToString().Trim() + "'";//+ cbPasajeros.SelectedValue.ToString().Trim() + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Pasajeros");
            dgvPasajeros.DataSource = dt;
        
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Pasajeros";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
            dgvPasajeros.DataSource = dt;
            
            cbPasajeros.DataSource = dt;
            cbPasajeros.ValueMember = "IdPasajero";
            cbPasajeros.DisplayMember = "IdPasajero";
            cbPasajeros.SelectedIndex = -1;
        }

        private void btnFiltrarDni_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Pasajeros where Dni ";

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                radioButton3.Checked = true;
            }
            if (radioButton1.Checked == true)
            {
                consultar += "> '" + cbDniPasajero.Text + "'";
            }
            if (radioButton2.Checked == true)
            {
                consultar += "< '" + cbDniPasajero.Text + "'";
            }
            if (radioButton3.Checked == true)
            {
                consultar += "= '" + cbDniPasajero.Text + "'";
            }

            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Pasajeros");
           dgvDniPasajero.DataSource = dt;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Pasajeros";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
            dgvDniPasajero.DataSource = dt;
           
            
        }

        private void btnFiltrarApellido_Click(object sender, EventArgs e)
        {
            if (cbApellidosZ.Checked == true && cbApellidosA.Checked == true)
            {
                MessageBox.Show("Seleccionar un solo orden", "Pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbApellidosA.Checked = false;
                cbApellidosZ.Checked = false;


            }
            string consulta = "Select * from Pasajeros order by Apellido ";
            if(cbApellidosA.Checked==true)
            {
                consulta += "asc";
            }
            if (cbApellidosZ.Checked==true)
            {
                consulta += "desc";
            }
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
            dgvApellidos.DataSource = dt;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string consulta = "select * from pasajeros where IdPasajero >= 'PS";
            // DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pasajeros");
        }

     
        
        }
    
}