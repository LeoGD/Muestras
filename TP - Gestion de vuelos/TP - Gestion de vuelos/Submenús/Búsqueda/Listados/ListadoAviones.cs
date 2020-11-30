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
    public partial class ListadoAviones : Form
    {
        public ListadoAviones()
        {
            InitializeComponent();
        }

        private void ListadoAviones_Load(object sender, EventArgs e)
        {
                    
            string consulta = "select * from Aviones";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Aviones");
            dgvAviones.DataSource = dt;

            cbAviones.DataSource = dt;
            cbAviones.ValueMember = "IdAvion";
            cbAviones.DisplayMember = "IdAvion";
            cbAviones.SelectedIndex = -1;
        }

        private void btnFiltrarAviones_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Aviones where IdAvion ";

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                radioButton1.Checked = true;
            }
            if(radioButton1.Checked == true)
            {
                consultar += "= '" + cbAviones.Text + "'";
            }
            if(radioButton2.Checked==true)
            {
                consultar += "> '" + cbAviones.Text + "'";
            }
            if (radioButton3.Checked == true)
            {
                consultar += "< '" + cbAviones.Text + "'";
            }
            
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Destinos");
            dgvAviones.DataSource = dt;
        }

        private void btnQuitarFiltroAviones_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Aviones";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Destinos");
            dgvAviones.DataSource = dt;
        }
    }
}
