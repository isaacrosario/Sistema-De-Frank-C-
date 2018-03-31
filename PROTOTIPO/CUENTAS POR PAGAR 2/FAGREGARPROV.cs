using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR_2
{
    public partial class FAGREGARPROV : Form
    {
        public FAGREGARPROV()
        {
            InitializeComponent();
        }

        private void FAGREGARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNOMBRES.Focus();
            }
        }

        private void TNOMBRES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                TAPELLIDOS.Focus();
            }
        }

        private void TAPELLIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TDIRECCION.Focus();
            }
        }

        private void TDIRECCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                TCIUDAD.Focus();
            }
        }

        private void TCIUDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TTELEFONO.Focus();

            }
        }

        private void TTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BAGREGAR.PerformClick();
            }
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {

            DATOSPROVEEDORES.INSERTARPROVEEDOR
                (
                TCODIGO.Text,
                TNOMBRES.Text,
                TAPELLIDOS.Text,
                TDIRECCION.Text,
                TCIUDAD.Text,
                TTELEFONO.Text
                );

            MessageBox.Show("EL PROVEEDOR " + "" + TNOMBRES.Text + "" + TAPELLIDOS.Text + "" + " HA SIDO AGREGADO", "AGREGAR PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
