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
    public partial class FMENUPRI : Form
    {
        public FMENUPRI()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPROVEEDORES FMP = new FPROVEEDORES();
            FMP.Show();
        }

        private void reporteProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPROVEEDORES FRP = new FRPROVEEDORES();
            FRP.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FFACTURAS FF = new FFACTURAS();
            FF.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRFACTURAS FRF = new FRFACTURAS();
            FRF.Show();
        }

        private void estadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FESTADO_DE_CUENTAS FEC = new FESTADO_DE_CUENTAS();
            FEC.Show();
        }

        private void reporteDeEstadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FRESTADO FRE = new FRESTADO();
            FRE.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCHEQUES FCHQ = new FCHEQUES();
            FCHQ.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRCHEQUES FRCHQ = new FRCHEQUES();
            FRCHQ.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FINICIO FI = new FINICIO();

            this.Hide();
            FI.Show();
        }
    }
}
