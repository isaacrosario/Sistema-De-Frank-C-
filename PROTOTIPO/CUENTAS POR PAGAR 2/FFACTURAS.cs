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
    public partial class FFACTURAS : Form
    {
        public FFACTURAS()
        {
            InitializeComponent();
        }

        private void FFACTURAS_Load(object sender, EventArgs e)
        {

            //INVOCAMOSEL METODO  MOSTRAR FACTURAS DE LA CLASE DATOSFACTURAS
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();

            //OCULTAMOS LA COLUMNA PROVEEDORES Y CHEQUES PARA QUE NO APAREZCAN EN EL DATAGRIDVIEW
            DGVFACTURAS.Columns["PROVEEDORES"].Visible = false;
            DGVFACTURAS.Columns["CHEQUES"].Visible = false;
        }

        private void TNUMFACT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFACTURAS.DataSource = DATOSFACTURAS.BUSCARELNUMERO


                    (Convert.ToInt32(TNUMFACT.Text));
            }
            catch { }
        }

        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.BUSCARELCODIGO(TCODIGO.Text);
        }

        private void FFACTURAS_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARFACT FAF = new FAGREGARFACT();
            FAF.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFACTURAS_FormClosed);
            FAF.Show();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DGVFACTURAS.CurrentRow;
                int numerofactura = Convert.ToInt16(FILA.Cells[0].Value);
                FMODIFICARFACT FMF = new FMODIFICARFACT(numerofactura);
                FMF.Show();
                FMF.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFACTURAS_FormClosed);
            }
            catch { }
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult respuesta = MessageBox.Show
                        ("DESEA ELIMINAR ESTA FACTURA?", "ADVERTENCIA DE ELMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (respuesta == DialogResult.Yes)
                    {
                        DataGridViewRow FILA = DGVFACTURAS.CurrentRow;
                        int numerofactura = Convert.ToUInt16(FILA.Cells[0].Value);
                        DATOSFACTURAS.ELIMINARFACTURA(numerofactura);
                        MessageBox.Show("SE HA BORRADO LA FACTURA " + numerofactura, "REGISTRO ELMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
                        

                    }
                }
            }

            catch
            {
                MessageBox.Show("VERIFIQUE QUE LOS CHEQUES RELACIONADOS CON ESTE PROVEEDOR SEAN BORRADOS PRIMERO",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
       
        }

        private void BVERTODO_Click(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARFACTURAS();
            TCODIGO.Clear();
            TNUMFACT.Clear();
        }
    }
}
