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
    public partial class FESTADO_DE_CUENTAS : Form
    {
        public FESTADO_DE_CUENTAS()
        {
            InitializeComponent();
        }

        private void FESTADO_DE_CUENTAS_Load(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADODECUENTAS.MOSTRARESTADO();
        }

        private void TPORCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADODECUENTAS.BUSCARPORCODIGO(TPORCODIGO.Text);
        }

        private void TPORNUMEROFACTURA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVESTADODECUENTA.DataSource = DATOSESTADODECUENTAS.BUSCARPORNUMERODEFACTURA(int.Parse(TPORNUMEROFACTURA.Text));
            }
            catch { }
        }

        private void BVERTODO_Click(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADODECUENTAS.MOSTRARESTADO();
        }
    }
}
