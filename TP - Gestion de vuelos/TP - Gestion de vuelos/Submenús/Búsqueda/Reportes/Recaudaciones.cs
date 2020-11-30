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
    public partial class Recaudaciones : Form
    {
        public Recaudaciones()
        {
            InitializeComponent();
        }

        private void Recaudaciones_Load(object sender, EventArgs e)
        {
            string consultar = " select  sum(detalle_pagos.ImporteSubtotal)as Recaudacion,IdVuelo from detalle_pagos group by IdVuelo";
            DataTable dt = ConexionTabla.devuelveTabla(consultar, "Detalle_Pagos");
            dgvRecaudacion.DataSource = dt;
        }
    }
}
