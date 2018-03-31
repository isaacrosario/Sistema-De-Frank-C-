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
    public partial class FMODIFICARPROV : Form
    {
        private string CODIGO;

        public FMODIFICARPROV(string CODIGOPROVEEDOR)
        {
            InitializeComponent();
            CODIGO = CODIGOPROVEEDOR;
           
            
        }

        private void FMODIFICARPROV_Load(object sender, EventArgs e)
        {
            TCODIGO.Enabled = false;
            TNOMBRE.Focus();
            PROVEEDORES prov = DATOSPROVEEDORES.CARGAR(CODIGO);
            CODIGO = prov.CODIGO;
            TNOMBRE.Text = prov.NOMBRES;
            TAPELLIDOS.Text = prov.APELLIDOS;
            TDIRECCION.Text = prov.DIRECCION;
            TCIUDAD.Text = prov.CIUDAD;
            TTELEFONO.Text = prov.TELEFONO;
 
        }

        private void FMODIFICARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {
            //Invocamos el metodo modificar
            DATOSPROVEEDORES.MODIFICARPROVEEDOR(CODIGO, TNOMBRE.Text, TAPELLIDOS.Text,
                TDIRECCION.Text, TCIUDAD.Text, TTELEFONO.Text);

            MessageBox.Show("El REGISTRO SE MODIFICO EXITOSAMENTE", "MODIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void TNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
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
                BACTUALIZAR.PerformClick();

            }
        }
    }
}
