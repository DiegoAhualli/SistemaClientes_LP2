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
    public partial class frmPantallaPpal : Form
    {
        public frmPantallaPpal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe Ventana = new frmAcercaDe();
            Ventana.ShowDialog();
        }

        private void agregarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoSocio Ventana = new frmNuevoSocio();
            Ventana.ShowDialog();
        }

        private void buscarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarSocio Ventana = new frmBuscarSocio();
            Ventana.ShowDialog();
        }

        private void consultaDeUnSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSocio Ventana = new frmConsultarSocio();
            Ventana.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocios Ventana = new frmListadoSocios();
            Ventana.ShowDialog();
        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSociosDeudores Ventana = new frmListadoSociosDeudores();
            Ventana.ShowDialog();
        }

        private void listadoDeSociosPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSociosXActividad Ventana = new frmListadoSociosXActividad();
            Ventana.ShowDialog();
        }

        private void listadoDeSociosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSociosXBarrio Ventana = new frmListadoSociosXBarrio();
            Ventana.ShowDialog();
        }
    }
}
