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
    public partial class FINICIO : Form
    {
        public FINICIO()
        {
            InitializeComponent();
        }

        private void FINICIO_Load(object sender, EventArgs e)
        {
            //Para mostrar los datos de los usuarios
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();
            //Para ocultal la clave
            DGVUSUARIOS.Columns[1].Visible = false;
            //  difrazar los caracteres escritos en el TEXTBOX  TCLAVE
            TCLAVE.PasswordChar = '*';
        }

        private void BENTRADA_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DGVUSUARIOS.CurrentRow;
                //Para copiar los valores de las columnas en las variables US y CL
                string US = Convert.ToString(FILA.Cells[0].Value);
                string CL = Convert.ToString(FILA.Cells[1].Value);
                //Para validar el usuario y la contrasena

                if (TUSUARIO.Text == US & TCLAVE.Text == CL)
                {
                    FMENUPRI FP = new FMENUPRI();
                    FP.Show();
                    this.Hide();
                }

                else
                {
                    //Si dejo los campos en blanco
                    MessageBox.Show("USUARIO Y CONTRASEÑA INVALIDOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TUSUARIO.Clear();
                    TCLAVE.Clear();
                    TUSUARIO.Focus();

                }
            }

            catch
            {
                //Si el usuario y la contrrasena no coinciden o son incorrectos
                MessageBox.Show("USUARIO O CONTRASEÑAS INVALIDOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TUSUARIO.Clear();
                TCLAVE.Clear();
                TUSUARIO.Focus();
            }
        }

        private void TUSUARIO_TextChanged(object sender, EventArgs e)
        {
            // Para invocar el metodo TUSUARIO
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORUSUARIO(TUSUARIO.Text);
        }

        private void TCLAVE_TextChanged(object sender, EventArgs e)
        {
            //Para invocar el metodo BUSCAR CLAVE
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORCLAVE(TCLAVE.Text);
        }

        private void TUSUARIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TCLAVE.Focus();
            }
        }

        private void TCLAVE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BENTRADA.PerformClick();
            }
        }
    }
}
