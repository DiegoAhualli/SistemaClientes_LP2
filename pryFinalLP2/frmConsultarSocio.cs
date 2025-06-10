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
    public partial class frmConsultarSocio : Form
    {
        public frmConsultarSocio()
        {
            InitializeComponent();
        }

        private void frmConsultarSocio_Load(object sender, EventArgs e)
        {
            clsSocio soc = new clsSocio();
            soc.Listar(cmbSocio);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 idSocio = Convert.ToInt32(cmbSocio.SelectedValue);
            clsSocio soc = new clsSocio();
            clsActividad act = new clsActividad();
            clsBarrio bar = new clsBarrio();
            soc.Buscar(idSocio);
            lblIdSocio.Text = soc.IdSocio.ToString();
            lblDireccion.Text = soc.Direccion;
            lblDeuda.Text = soc.Deuda.ToString();
            lblActividad.Text = act.Buscar(soc.idActividad);
            lblBarrio.Text = bar.Buscar(soc.idBarrio);
        }

        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
