using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMPersonas
{
    public partial class FrmPersona : Form
    {
        Personas oPersona = new Personas();
        int i = 0;
        public FrmPersona()
        {
            InitializeComponent();
        }
    
        public void LimpiarCampos()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDoc.Text = string.Empty;
            rbtMasculino.Checked = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            cbTipoDoc.Enabled = false;
            txtDoc.Enabled = false;
            cbEstado.Enabled = false;
            rbtMasculino.Enabled = false;
            rbtFemenino.Enabled = false;
            cbxFallecimiento.Enabled = false;

            btnNuevo.Enabled = true;
            btnEditar.Enabled =true;
            btnBorrar.Enabled =true;
            btnSalir.Enabled = true;
            lbxPersonas.Enabled = true;

            txtNombre.Text = "Juan";
            txtApellido.Text = "Perez";
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            lbxPersonas.Focus(); 
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDoc.Text = string.Empty;
            rbtMasculino.Checked = false;

            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            cbTipoDoc.Enabled = true;
            txtDoc.Enabled = true;
            cbEstado.Enabled = true;
            rbtMasculino.Enabled = true;
            rbtFemenino.Enabled = true;
            cbxFallecimiento.Enabled = true;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            btnSalir.Enabled = false;
            lbxPersonas.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar?", "Confirmación de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(i != 5)
            {
                MessageBox.Show("Grabación exitosa", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Question);

                oPersona.personas[i] = txtApellido.Text + " - " + txtNombre.Text;
                lbxPersonas.Items.Add(oPersona.personas[i]);

                LimpiarCampos();

                i++;
            } else
            {
                MessageBox.Show("Ya no se puede", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
