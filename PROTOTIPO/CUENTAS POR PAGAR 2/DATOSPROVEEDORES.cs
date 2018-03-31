using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR_2
{
   public class DATOSPROVEEDORES
    {

       
    

     //El SIGUIENTE METODO MUESTRA TODOS LOS PROVEEDORES
     public static List<PROVEEDORES> MOSTRARDATOS()

     { 
     
     //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DATOS

         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var INFO = (from P in BD.PROVEEDORES select P).ToList();

             return INFO;
         
         }
     
     
     }

     public static List<PROVEEDORES> BUSCARPORCODIGO(string codigo)
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         { 
         /* USAMOS LINQ. PARA BUSCAR UN PROVEEDOR POR LA DIRECCION 
             EMPEZANDO POR CUALQUIER LETRA */
             var INFO = (from P in BD.PROVEEDORES where P.CODIGO.StartsWith(codigo) 
                         select P).ToList();

             /* StartWith HACE QUE VAYA MOSTRANDO LOS PROVEEDORES 
             QUE EMPIEZEN CON LAS LETRAS QUE VAMOS ESCRIBIENDO */
                

             return INFO;
         
         
         }
     
     
     }


     public static List<PROVEEDORES> BUSCARPORNOMBRE(string nombres)
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var INFO = (from P in BD.PROVEEDORES
                         where P.NOMBRES.StartsWith(nombres)
                         select P).ToList();
             return INFO;
         }


     }






     public static List<PROVEEDORES> BUSCARPORAPELLIDO(string apellidos)
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var INFO = (from P in BD.PROVEEDORES
                         where P.APELLIDOS.StartsWith(apellidos)                        
                         select P).ToList();
             return INFO;                                                       
         }
     
     
     }

     public static List<PROVEEDORES> BUSCARPORDIRECCION(string direccion)
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var INFO = (from P in BD.PROVEEDORES
                         where P.DIRECCION.StartsWith(direccion)
                         select P).ToList();
             return INFO;

         }


     }
     public static List<PROVEEDORES> BUSCARPORCIUDAD(string ciudad)
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var INFO = (from P in BD.PROVEEDORES
                         where P.CIUDAD.StartsWith(ciudad)
                         select P).ToList();                    
             return INFO;

         }


     }

     public static void INSERTARPROVEEDOR
         (
         string codigo,
         string nombres,
         string apellidos,
         string direccion,
         string ciudad,
         string telefono
         )
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             /* PARA ASIGNAR UN NUEVO OBJETO O PROVEEDOR ASIGNANDO LOS VALORES
              DE LOS PARAMETROS A LOS CAMPOS DE LA TABLA */

             BD.PROVEEDORES.Add(new PROVEEDORES
                 {
             

                 CODIGO = codigo,
                 NOMBRES = nombres,
                 APELLIDOS = apellidos,
                 DIRECCION = direccion,
                 CIUDAD = ciudad,
                 TELEFONO = telefono
                 
                 

             });
             BD.SaveChanges();    
         }
     
     }
    



// METODO PARA MODIFICAR PROVEEDORES
     public static void MODIFICARPROVEEDOR
         (string codigo,
         string nombres,
     string apellidos,
         string direccion,
         string ciudad,
         string telefono
         )
     {
         using (SCXPEntities1 BD = new SCXPEntities1())
         {
             var MODIFICAR = (from P in BD.PROVEEDORES where P.CODIGO == codigo select P).Single();
             MODIFICAR.CODIGO = codigo;
             MODIFICAR.NOMBRES = nombres;
             MODIFICAR.APELLIDOS = apellidos;
             MODIFICAR.DIRECCION = direccion;
             MODIFICAR.CIUDAD = ciudad;
             MODIFICAR.TELEFONO = telefono;
             BD.SaveChanges();
         }
     }
    

     
     public static void ELIMINARPROVEEDOR(string codigo) 
     {
         //ESTE ES EL METODO QUE SE LLAMA ELIMINAPROVEEDORES. TIENE EL PARAMETRO codigo QUE
         //USAREMOS PARA BUSCAR Y ELIMINAR
         using (SCXPEntities1 BD = new SCXPEntities1()) 
         
         { 
         var ELIMINA =(from P in BD.PROVEEDORES where P.CODIGO==codigo select P).Single();
         BD.PROVEEDORES.Remove(ELIMINA);
         BD.SaveChanges();
         
         }
     }

     public static PROVEEDORES CARGAR(string codigo)
     {
         PROVEEDORES proveedores = new PROVEEDORES();
         using (SCXPEntities1 BD = new SCXPEntities1())
         {

             var INFO = (from P in BD.PROVEEDORES where P.CODIGO == codigo select P).Single();

             proveedores.CODIGO = INFO.CODIGO;
             proveedores.NOMBRES = INFO.NOMBRES;
             proveedores.APELLIDOS = INFO.APELLIDOS;
             proveedores.DIRECCION = INFO.DIRECCION;
             proveedores.CIUDAD = INFO.CIUDAD;
             proveedores.TELEFONO = INFO.TELEFONO;
             
             
             return proveedores;
             

         }
     }
 }



}
