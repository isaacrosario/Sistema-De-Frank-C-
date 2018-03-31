using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR_2
{
    public class DATOSFACTURAS
    {
        public static List<FACTURAS> MOSTRARFACTURAS()
        {


            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE BASE DE DATO
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                //MUESTRA TODAS LAS FACTURAS  
                var INFO = (from F in BD.FACTURAS select F).ToList();
                return INFO;

            }

        }
        public static List<FACTURAS> BUSCARELNUMERO(int numerofactura)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                //USAMOS LINQ PARA BUSCAR UNA FACTURA POR EL NUMERO

                var INFO = (from F in BD.FACTURAS
                            where F.NUMERO_FACTURA == numerofactura

                            select F).ToList();


                return INFO;
            }
        }



        public static List<FACTURAS> BUSCARELCODIGO(string codigo)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                //var INFO = (from F in BD.FACTURAS where F.CODIGO == codigo select F).ToList(); //ESTE ES EL DEL LIBRO
                var INFO = (from F in BD.FACTURAS where F.CODIGO.StartsWith(codigo) select F).ToList();
                //ESTA ES MI MODIFICACION

                return INFO;


            }

        }

        //EL SIGUIENTE METODO AÑADE UNA NUEVO REGITRO
        public static void INSERTARFACTURA

        (
        int numerofactura,
        string codigoproveedor,
            decimal valorfactura,
            DateTime fechafactura,
                DateTime fechavencimiento
            )
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                BD.FACTURAS.Add(new FACTURAS
                {

                    NUMERO_FACTURA = numerofactura,
                    CODIGO = codigoproveedor,
                    VALOR_FACTURA = valorfactura,
                    FECHA_FACTURA = fechafactura,
                    FECHA_VENCIMIENTO = fechavencimiento

                }); BD.SaveChanges();
            }
        }

        public static void MODIFICARFACTURAS
            (
        int numerofactura,
        string codigoproveedor,
        decimal valorfactura,
        DateTime fechafactura,
        DateTime fechavencimiento)
        {
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var MODIFICAR = (from F in BD.FACTURAS
                                 where F.NUMERO_FACTURA == numerofactura
                                 select F).Single();
                MODIFICAR.NUMERO_FACTURA = numerofactura;
                MODIFICAR.CODIGO = codigoproveedor;
                MODIFICAR.VALOR_FACTURA = valorfactura;
                MODIFICAR.FECHA_FACTURA = fechafactura;
                MODIFICAR.FECHA_VENCIMIENTO = fechavencimiento;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARFACTURA(int numerofactura)
        {

            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var ELIMINA = (from F in BD.FACTURAS
                               where F.NUMERO_FACTURA == numerofactura
                               select F).Single();
                BD.FACTURAS.Remove(ELIMINA);
                BD.SaveChanges();
            }


        }
        public static FACTURAS CARGAR(int numerofactura)
        {
            FACTURAS facturas = new FACTURAS();
            using (SCXPEntities1 BD = new SCXPEntities1())
            {
                var INFO = (from F in BD.FACTURAS
                            where F.NUMERO_FACTURA == numerofactura
                            select F).Single();

                facturas.NUMERO_FACTURA = INFO.NUMERO_FACTURA;
                facturas.CODIGO = INFO.CODIGO;
                facturas.VALOR_FACTURA = INFO.VALOR_FACTURA;
                facturas.FECHA_FACTURA = INFO.FECHA_FACTURA;
                facturas.FECHA_VENCIMIENTO = INFO.FECHA_VENCIMIENTO;

                return INFO;
            }


        }

    }
}
      
      
      
      
      
      
    


