using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR_2
{
   public class DATOSCHEQUES
    {



        public static List<CHEQUES> MOSTRARCHEQUES()
        {


            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE BASE DE DATOS
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                //MUESTRA TODAS LOS CHEQUES
                var INFO = (from C in BD.CHEQUES select C).ToList();
                return INFO;

            }

        }
        public static List<CHEQUES> BUSCARELNUMERO(int numerocheque)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                //USAMOS LINQ PARA BUSCAR UN CHEQUE POR EL NUMERO

                var INFO = (from C in BD.CHEQUES
                            where C.NUMERO_CHEQUE == numerocheque
                            select C).ToList();
                return INFO;
            }
        }
        public static List<CHEQUES> BUSCARNUMERO_FACTURA(int NUMERO_FACTURA)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {


                var INFO = (from C in BD.CHEQUES
                            where C.NUMERO_FACTURA == NUMERO_FACTURA
                            select C).ToList();
                return INFO;
            }
        }
        public static void INSERTARCHEQUE

          (
          int numerocheque,
          int numero_factura,
              decimal valor_cheque,
              DateTime fecha_cheque

              )
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                BD.CHEQUES.Add(new CHEQUES
                {

                    NUMERO_CHEQUE = numerocheque,
                    NUMERO_FACTURA = numero_factura,
                    VALOR_CHEQUE = valor_cheque,
                    FECHA_CHEQUE = fecha_cheque


                }); BD.SaveChanges();
            }
        }

        public static void MODIFICARCHEQUE
            (
          int numerocheque,
          int numero_factura,
              decimal valor_cheque,
              DateTime fecha_cheque
            )
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var MODIFICAR = (from C in BD.CHEQUES
                                 where C.NUMERO_CHEQUE == numerocheque
                                 select C).Single();
                MODIFICAR.NUMERO_CHEQUE = numerocheque;
                MODIFICAR.NUMERO_FACTURA = numero_factura;
                MODIFICAR.VALOR_CHEQUE = valor_cheque;
                MODIFICAR.FECHA_CHEQUE = fecha_cheque;

                BD.SaveChanges();
            }
        }
        public static void ELIMINARCHEQUE(int numerocheque)
        {

            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var ELIMINA = (from C in BD.CHEQUES
                               where C.NUMERO_CHEQUE == numerocheque
                               select C).Single();
                BD.CHEQUES.Remove(ELIMINA);
                BD.SaveChanges();
            }
        }
        public static CHEQUES CARGAR(int numerocheque)
        {
            CHEQUES CHEQUES = new CHEQUES();
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var INFO = (from C in BD.CHEQUES
                            where C.NUMERO_CHEQUE == numerocheque
                            select C).Single();

                CHEQUES.NUMERO_CHEQUE = INFO.NUMERO_CHEQUE;
                CHEQUES.NUMERO_FACTURA = INFO.NUMERO_FACTURA;
                CHEQUES.VALOR_CHEQUE = INFO.VALOR_CHEQUE;
                CHEQUES.FECHA_CHEQUE = INFO.FECHA_CHEQUE;



                return CHEQUES;
            }


        }


    }
}
