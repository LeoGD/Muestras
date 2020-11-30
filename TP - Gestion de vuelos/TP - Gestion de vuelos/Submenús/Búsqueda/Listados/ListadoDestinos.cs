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
    public partial class ListadoDestinos : Form
    {
        public ListadoDestinos()
        {
            InitializeComponent();
        }

        private void ListadoDestinos_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Destinos order by LugarDestino asc";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");
            
            dgv.DataSource = dt;
            dgvPaisDestino.DataSource = dt;

            cbDestinos.DataSource = dt;
            cbDestinos.ValueMember = "IdDestino";
            cbDestinos.DisplayMember = "IdDestino";
            cbDestinos.SelectedIndex = -1;
            string con = "Select distinct Nombre from Destinos inner join Paises on Paises.IdPais = Destinos.IdPais";
            DataTable data = ConexionTabla.devuelveTabla(con, "Destinos");
            cbPaisDestino.DataSource = data;
            cbPaisDestino.ValueMember = "Nombre";
            cbPaisDestino.DisplayMember = "IdPais";
            cbPaisDestino.SelectedIndex = -1;
           
            
        }

        private void btnFiltrarDestino_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Destinos where IdDestino = '" + cbDestinos.SelectedValue + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Destinos");
            dgv.DataSource = dt;
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFiltrarPaisDestino_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Destinos inner join Paises on Destinos.IdPais = Paises.IdPais where Nombre ='" + cbPaisDestino.SelectedValue + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Destinos");
            dgvPaisDestino.DataSource = dt;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Destinos";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Destinos");
            dgvPaisDestino.DataSource = dt;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
