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
    public partial class PagosRealizados : Form
    {
        public PagosRealizados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PagosRealizados_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Pagos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pagos");
            dgvPagos.DataSource = dt;

            cbPagos.DataSource = dt;
            cbPagos.ValueMember = "IdPago";
            cbPagos.DisplayMember = "IdPago";
            cbPagos.SelectedIndex = -1;
        }

        private void btnFiltrarPagos_Click(object sender, EventArgs e)
        {
            string consultar = "select * from Pagos where Idpago ";

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                radioButton1.Checked = true;
            }
            if (radioButton1.Checked == true)
            {
                consultar += "= '" + cbPagos.Text + "'";
            }
            if (radioButton2.Checked == true)
            {
                consultar += "> '" + cbPagos.Text + "'";
            }
            if (radioButton3.Checked == true)
            {
                consultar += "< '" + cbPagos.Text + "'";
            }

            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Pagos");
            dgvPagos.DataSource = dt;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Pagos";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Pagos");
            dgvPagos.DataSource = dt;
        }
    }
}
