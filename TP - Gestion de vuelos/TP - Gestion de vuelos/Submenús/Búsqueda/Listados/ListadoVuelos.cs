using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP___Gestion_de_vuelos
{
    public partial class ListadoVuelos : Form
    {
        public ListadoVuelos()
        {
            InitializeComponent();
        }

        private void ListadoVuelos_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
            dgvVuelos.DataSource = dt;
            dgvFechaVuelo.DataSource = dt;

            cbVuelos.DataSource = dt;
            cbVuelos.ValueMember = "IdVuelo";
            cbVuelos.DisplayMember = "IdVuelo";
            cbVuelos.SelectedIndex = -1;
        }

        private void btnFiltrarAviones_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Vuelos where IdVuelo = '" + cbVuelos.SelectedValue + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Vuelos");
            dgvVuelos.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos where FechaVuelo > '" + dateTimePicker1.Value.ToShortDateString() + "' and FechaVuelo < '" + dateTimePicker2.Value.ToShortDateString() + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
            dgvFechaVuelo.DataSource = dt;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
        
            dgvFechaVuelo.DataSource = dt;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Vuelos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Vuelos");
            dgvVuelos.DataSource = dt;
        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
