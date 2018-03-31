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
    public partial class FCHEQUES : Form
    {
        public FCHEQUES()
        {
            InitializeComponent();
        }

        private void FCHEQUES_Load(object sender, EventArgs e)
        {
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            DGVCHEQUES.Columns["FACTURAS"].Visible = false;
        }

        private void TNUMCHEQ_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DGVCHEQUES.DataSource = DATOSCHEQUES.BUSCARELNUMERO(int.Parse(TNUMCHEQ.Text));


            }
            catch
            {
                //MessageBox.Show("LA ENTRADA DEBE SER NUMERICA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //TNUMCHEQ.Focus();

            }
        }

        private void TNUMFACT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVCHEQUES.DataSource = DATOSCHEQUES.BUSCARELNUMERO(int.Parse(TNUMFACT.Text));
            }
            catch
            {
                //    MessageBox.Show("LA ENTRADA DEBE SER NUMERICA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    TNUMFACT.Focus();

            }
        }

        private void FCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARCHEQUES FAC = new FAGREGARCHEQUES();
            FAC.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            FAC.Show();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow FILA = DGVCHEQUES.CurrentRow;
                int numero = Convert.ToInt16(FILA.Cells[0].Value);
                FMODIFICARCHEQUES FMP = new FMODIFICARCHEQUES(numero);
                FMP.Show();
                FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            }
            catch { }
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show
             ("DESEA ELIMINAR ESTE CHEQUE?", "ADVERTENCIA DE ELMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVCHEQUES.CurrentRow;
                int numerocheque = Convert.ToUInt16(FILA.Cells[0].Value);
                DATOSCHEQUES.ELIMINARCHEQUE(numerocheque);
                MessageBox.Show("SE HA BORRADO EL CHEQUE " + numerocheque, "REGISTRO ELMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
                
            }
        }

        private void BVERTODO_Click(object sender, EventArgs e)
        {
            DGVCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            TNUMCHEQ.Clear();
            TNUMFACT.Clear();
        }
    }
}
