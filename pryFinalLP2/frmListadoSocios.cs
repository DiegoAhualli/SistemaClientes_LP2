using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinalLP2
{
    public partial class frmListadoSocios : Form
    {
        public frmListadoSocios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio objSocio = new clsSocio();
            objSocio.ListarSocios(Grilla);
            lblMenorDeudor.Text = objSocio.MenorDeudor.ToString("0.00");
            lblMayorDeudor.Text = objSocio.MayorDeudor.ToString("0.00");
            lblTotalDeuda.Text = objSocio.TotalDeuda.ToString("0.00");
            lblPromedioDeuda.Text = objSocio.PromedioDeuda.ToString("0.00");
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos de texto separados por coma (*.csv)|*.csv|Archivos de Texto (*.txt)|*.txt";
            objArchivo.ShowDialog();
            clsSocio soc = new clsSocio();
            soc.ReporteClientes(objArchivo.FileName);
            MessageBox.Show("Reporte generado.");
        }

        private void frmListadoSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso.");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio soc = new clsSocio();
            soc.Imprimir(e);
        }
    }
}
