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
    public partial class frmListadoSociosXBarrio : Form
    {
        public frmListadoSociosXBarrio()
        {
            InitializeComponent();
        }

        private void frmListadoSociosXBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio bar = new clsBarrio();
            bar.Listar(cmbBarrio);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            clsSocio soc = new clsSocio();
            soc.ListarSociosXBarrio(dgvGrilla, idBarrio);
            btnImprimir.Enabled = true;
            btnReporte.Enabled = true;
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
            Int32 idAct = Convert.ToInt32(cmbBarrio.SelectedValue);
            clsSocio soc = new clsSocio();
            soc.ReporteSociosBarrio(idAct, objArchivo.FileName);
            MessageBox.Show("Reporte generado.");
        }
    }
}
