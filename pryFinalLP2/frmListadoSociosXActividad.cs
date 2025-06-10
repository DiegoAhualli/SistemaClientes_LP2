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
    public partial class frmListadoSociosXActividad : Form
    {
        public frmListadoSociosXActividad()
        {
            InitializeComponent();
        }

        private void frmListadoSociosXActividad_Load(object sender, EventArgs e)
        {
            clsActividad act = new clsActividad();
            act.Listar(cmbActividad);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 idAct = Convert.ToInt32(cmbActividad.SelectedValue);
            clsSocio soc = new clsSocio();
            soc.ListarSociosXActividad(dgvGrilla, idAct);
            btnReporte.Enabled = true;
            btnImprimir.Enabled = true;
            lblMenorDeudor.Text = soc.MenorDeudor.ToString("0.00");
            lblMayorDeudor.Text = soc.MayorDeudor.ToString("0.00");
            lblTotalDeuda.Text = soc.TotalDeuda.ToString("0.00");
            lblPromedioDeuda.Text = soc.PromedioDeuda.ToString("0.00");
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos de texto separados por coma (*.csv)|*.csv|Archivos de Texto (*.txt)|*.txt";
            objArchivo.ShowDialog();
            Int32 idAct = Convert.ToInt32(cmbActividad.SelectedValue);
            clsSocio soc = new clsSocio();
            soc.ReporteSociosActividad(idAct, objArchivo.FileName);
            MessageBox.Show("Reporte generado.");
        }
    }
}
