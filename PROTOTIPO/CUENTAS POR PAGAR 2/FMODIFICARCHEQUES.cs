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
    public partial class FMODIFICARCHEQUES : Form
    {

        private int numero;

        public FMODIFICARCHEQUES(int numerocheque)
        {
            InitializeComponent();
            numero = numerocheque;
        }

        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMCHEQ.Focus();
            }
        }

        private void TNUMCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALCHEQ.Focus();
            }
        }

        private void TVALCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                TFECHACHEQ.Focus();
            }
        }

        private void TFECHACHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                BACTUALIZAR.PerformClick();
            }
        }

        private void FMODIFICARCHEQUES_Load(object sender, EventArgs e)
        {
            CHEQUES chq = DATOSCHEQUES.CARGAR(numero);
            numero = chq.NUMERO_FACTURA;
            TNUMCHEQ.Text = Convert.ToString(numero);
            TNUMFACT.Text = Convert.ToString(chq.NUMERO_FACTURA);
            TVALCHEQ.Text = Convert.ToString(chq.VALOR_CHEQUE);
            TFECHACHEQ.Text = Convert.ToString(chq.FECHA_CHEQUE);
            TNUMFACT.Enabled = false;
            TNUMCHEQ.Enabled = false;
        }

        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSCHEQUES.MODIFICARCHEQUE

                    (

                    int.Parse(TNUMFACT.Text), //el libro repite este parametro no obstante el que va es  int.Parse(TNUMCHEQ.Text),
                    int.Parse(TNUMCHEQ.Text),
                    Convert.ToDecimal(TVALCHEQ.Text),
                    Convert.ToDateTime(TFECHACHEQ.Text)




                    );
                MessageBox.Show("EL CHEQUE SE MODIFICO SATITACTORIAMENTE", "AGREGAR CHEQUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }



            catch
            {
                MessageBox.Show("VERIFIQUE QUE TODOS LOS DATOS SEAN INSERTADO CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
