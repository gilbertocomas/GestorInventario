using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        N_MovimientosProductos objNegocio = new N_MovimientosProductos();

        private void visualizacionIncremento()
        {
            DataTable dt = objNegocio.N_reporteIncrementoProductos();
            dgvReportes.DataSource = dt;
        }

        private void visualizacionDecremento()
        {
            DataTable dt = objNegocio.N_reporteDecrementoProductos();
            dgvReportes.DataSource = dt;
        }

        private void estadisticasReporte10Mayoresvendedores()
        {
            DataTable dt = objNegocio.N_10MayoresMovimientosProductos();
            dgvReportes.DataSource = dt;
        }

        private void btnIncremento_Click(object sender, EventArgs e)
        {
            visualizacionIncremento();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            visualizacionDecremento();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            estadisticasReporte10Mayoresvendedores();
        }
    }
}
