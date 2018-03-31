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
    public partial class FPROVEEDORES : Form
    {
        FAGREGARPROV FAP = new FAGREGARPROV();
        public FPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            DGVPROVEEDORES.Columns["FACTURAS"].Visible = false;
        }

        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORCODIGO(TCODIGO.Text);
        }

        private void TNOMBRE_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORNOMBRE(TNOMBRE.Text);
        }

        private void TAPELLIDOS_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORAPELLIDO(TAPELLIDOS.Text);
        }

        private void TDIRECCION_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TDIRECCION.Text);
        }

        private void TCIUDAD_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORCIUDAD(TCIUDAD.Text);
        }

        private void FPROVEEDORES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARPROV FGP = new FAGREGARPROV();



            //EL LIBRO DICE QUE PONGA FMODIFICARPROV FMP PERO NO ME CONVIENE




            // Abrimos el formulario y actualizamos DataGrid View DGVPROVEEDORES despues d  e cerrarlo
            FGP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);
            FGP.Show();
        }

        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNOMBRE.Focus();
            }
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

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
                string codigo = Convert.ToString(FILA.Cells[0].Value);

                FMODIFICARPROV FMP = new FMODIFICARPROV(codigo);
                FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);
                FMP.Show();
            }
            catch { }
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show
                    ("DESEA ELIMINAR EL PROVEEDOR?", "BORRAR PROVEEDOR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
                    string codigo = Convert.ToString(FILA.Cells[0].Value);
                    DATOSPROVEEDORES.ELIMINARPROVEEDOR(codigo);
                    MessageBox.Show("SE HA BORRADO EL PROVEEDOR " + TNOMBRE.Text + " " + TAPELLIDOS.Text + "REGISTRO ELIMINADO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();

                }
            }


            catch
            {
                MessageBox.Show("VERIFIQUE QUE LAS FACTURAS Y LOS CHEQUES RELACIONADOS CON ESTE PROVEEDOR SEAN BORRADOS PRIMERO",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BLIMPIAR_Click(object sender, EventArgs e)
        {
            TCODIGO.Clear();
            TNOMBRE.Clear();
            TAPELLIDOS.Clear();
            TDIRECCION.Clear();
            TCIUDAD.Clear();
            TTELEFONO.Clear();
            TCODIGO.Focus();
        }
            
    }
}
