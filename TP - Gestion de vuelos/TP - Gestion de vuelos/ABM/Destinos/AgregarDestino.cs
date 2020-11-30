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
    public partial class AgregarDestino : Form
    {
        public AgregarDestino()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarDestino_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Paises order by Nombre asc";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Paises");
            cbIDPais.DataSource = dt;
            cbIDPais.ValueMember = "IdPais";
            cbIDPais.DisplayMember = "Nombre";
            cbIDPais.SelectedIndex = -1;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string consulta = "Select IdDestino from Destinos where IdDestino = '" + txtIDDestino.Text + "'";
            DataTable dt = ConexionTabla.devuelveTabla(consulta, "Destinos");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Existe un IdDestino " + txtIDDestino.Text + " en la base de datos", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else   if (txtIDDestino.Text.Trim() == "" || txtLugarDestino.Text.Trim() == "" || txtAeropuerto.Text.Trim() == "" || txtImporte.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos sin completar", "Destinos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool estado;

                DatosDestinos Destino = new DatosDestinos();
                Destino.IdDestino = txtIDDestino.Text.Trim();
                Destino.IdPais = cbIDPais.SelectedValue.ToString();
                Destino.LugarDestino = txtLugarDestino.Text.Trim();
                Destino.Aeropuerto = txtAeropuerto.Text.Trim();
                Destino.ImporteDestino = Convert.ToInt32(txtImporte.Text.Trim());

                GestionarDestinos gDestino = new GestionarDestinos();
                estado = gDestino.Insertar(Destino);

                if (estado)
                {
                    MessageBox.Show("El destino fue agregado con exito");
                    //ActualizarGrilla();
                    //LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el destino");
                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbIDPais.SelectedIndex = -1;
            txtAeropuerto.Text = "";
            txtIDDestino.Text = "";
            txtImporte.Text = "";
            txtLugarDestino.Text = "";

        }

    }
}
