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
    public partial class frmNuevoSocio : Form
    {
        public frmNuevoSocio()
        {
            InitializeComponent();
        }

        private void frmNuevoSocio_Load(object sender, EventArgs e)
        {
            clsBarrio bar = new clsBarrio();
            clsActividad act = new clsActividad();
            bar.Listar(cmbBarrio);
            act.Listar(cmbActividad);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            clsSocio soc = new clsSocio();
            soc.IdSocio = Convert.ToInt32(txtSocio.Text);
            soc.Nombre = txtNombre.Text;
            soc.Direccion = txtDireccion.Text;
            soc.Deuda = 0;
            soc.idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            soc.idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            soc.AgregarNuevoRegistro();
            txtSocio.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cmbActividad.SelectedIndex = 0;
            cmbBarrio.SelectedIndex = 0;
        }

        private void ComprobarCajasTexto()
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ComprobarCajasTexto();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ComprobarCajasTexto();
        }


    }
}
