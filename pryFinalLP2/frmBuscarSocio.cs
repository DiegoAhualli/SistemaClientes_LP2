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
    public partial class frmBuscarSocio : Form
    {
        public frmBuscarSocio()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDeuda.Text = "";
            txtCodigo.ReadOnly = false;
            txtNombre.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtDeuda.ReadOnly = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            cmbBarrio.Enabled = false;
            cmbActividad.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdSocio = Convert.ToInt32(txtCodigo.Text);
            clsSocio soc = new clsSocio();
            soc.Buscar(IdSocio);
            if (soc.IdSocio == 0)
            {
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtDeuda.Text = "";
                cmbBarrio.SelectedIndex = 0;
                cmbActividad.SelectedIndex = 0;
                MessageBox.Show("Cliente no encontrado!!");
            }
            else
            {
                txtNombre.Text = soc.Nombre;
                txtDireccion.Text = soc.Direccion;
                txtDeuda.Text = soc.Deuda.ToString();
                cmbBarrio.SelectedValue = soc.idBarrio;
                cmbActividad.SelectedValue = soc.idActividad;
            }
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {
            clsActividad act = new clsActividad();
            clsBarrio bar = new clsBarrio();
            act.Listar(cmbActividad);
            bar.Listar(cmbBarrio);
            cmbBarrio.SelectedIndex = 0;
            cmbActividad.SelectedIndex = 0;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtDeuda.ReadOnly = false;
            cmbActividad.Enabled = true;
            cmbBarrio.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsSocio soc = new clsSocio();
            soc.Eliminar(id);
            MessageBox.Show("Socio eliminado exitosamente!");
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsSocio soc = new clsSocio();
            soc.Nombre = txtNombre.Text;
            soc.Direccion = txtDireccion.Text;
            soc.Deuda = Convert.ToDecimal(txtDeuda.Text);
            soc.idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            soc.idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            soc.Modificar(id);
            MessageBox.Show("Dato grabado exitosamente!");
            Limpiar();

        }
    }
}
