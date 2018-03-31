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
    public partial class FAGREGARFACT : Form
    {
        public FAGREGARFACT()
        {
            InitializeComponent();
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
                BAGREGAR.PerformClick();
            }
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSFACTURAS.INSERTARFACTURA
                    (

                    Convert.ToInt16(TNUMFACT.Text),
                    TCODIGO.Text,
                    Convert.ToDecimal(TVALFACT.Text),
                  Convert.ToDateTime(TFECHAFACT.Text),
                    Convert.ToDateTime(TFECHAVENC.Text));


                MessageBox.Show("LA FACTURA SE AGREGO SATIFACTORIAMENTE", "AGREGAR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch
            {

                MessageBox.Show("VERIFIQUE QUE TODOS LOS DATOS ESTEN INSERTADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //TNUMFACT.Clear();
                //    TFECHAFACT.Clear();
                //TFECHAVENC.Clear();
                //TCODIGO.Clear();
                //TVALFACT.Clear();
                //TNUMFACT.Focus();
            }
        }
    }
}
