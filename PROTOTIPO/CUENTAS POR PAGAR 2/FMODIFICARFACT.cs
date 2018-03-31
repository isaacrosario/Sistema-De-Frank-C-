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
    public partial class FMODIFICARFACT : Form
    {
        private int numero;
        public FMODIFICARFACT(int numerofactura)
        {
            InitializeComponent();
            numero = numerofactura;
        }

        private void FMODIFICARFACT_Load(object sender, EventArgs e)
        {
            FACTURAS fact = DATOSFACTURAS.CARGAR(numero);
            numero = fact.NUMERO_FACTURA;
            TNUMFACT.Text = Convert.ToString(fact.NUMERO_FACTURA);
            TCODIGO.Text = fact.CODIGO;
            TVALFACT.Text = Convert.ToString(fact.VALOR_FACTURA);
            TFECHAFACT.Text = Convert.ToString(fact.FECHA_FACTURA);
            TFECHAVENC.Text = Convert.ToString(fact.FECHA_VENCIMIENTO);
            TNUMFACT.Enabled = false;
            TCODIGO.Enabled = false;
            TVALFACT.Focus();
        }

        private void BACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                //Invocamos el metodo MODIFICARFACTURA
                DATOSFACTURAS.MODIFICARFACTURAS(

                      Convert.ToInt16(TNUMFACT.Text),
                    TCODIGO.Text,
                    Convert.ToDecimal(TVALFACT.Text),
                  Convert.ToDateTime(TFECHAFACT.Text),
                    Convert.ToDateTime(TFECHAVENC.Text));


                MessageBox.Show("LA FACTURA SE MODIFICO SATIFACTORIAMENTE", "MODICAR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("VERIFIQUE QUE TODOS LOS DATOS ESTEN INSERTADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNUMFACT.Focus();

            }
        }

        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                TCODIGO.Focus();
            }
        }

        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                TVALFACT.Focus();
            }
        }

        private void TVALFACT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHAFACT.Focus();
            }
        }

        private void TFECHAFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHAVENC.Focus();
            }
        }

        private void TFECHAVENC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BACTUALIZAR.PerformClick();
            }
        }
    }
}
