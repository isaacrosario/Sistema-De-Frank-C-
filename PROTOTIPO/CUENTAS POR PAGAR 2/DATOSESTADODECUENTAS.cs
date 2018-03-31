using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR_2
{
    public class DATOSESTADODECUENTAS
    {


        public static List<ESTADO_DE_CUENTAS> MOSTRARESTADO()
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {


                var INFO = (from E in BD.ESTADO_DE_CUENTAS
                            select E).ToList();
                return INFO;
            }
        }

        public static List<ESTADO_DE_CUENTAS> BUSCARPORNUMERODEFACTURA(int numerofactura)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {


                var INFO = (from E in BD.ESTADO_DE_CUENTAS
                            where E.NUMERO_FACTURA == numerofactura
                            select E).ToList();
                return INFO;



            }

        }

        public static List<ESTADO_DE_CUENTAS> BUSCARPORCODIGO(string codigo)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {


                //var INFO = (from E in BD.ESTADO_DE_CUENTAS
                //            where E.CODIGO == codigo
                //            select E).ToList();
                //return INFO;

                var INFO = (from E in BD.ESTADO_DE_CUENTAS
                            where E.CODIGO.StartsWith(codigo)
                            select E).ToList();
                return INFO;
            }


        }
    }
}