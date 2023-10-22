using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Clsmenu
    {
        static int opcion = 0;

         
        public Clsmenu() { }
        public static void Desplegar()
        {

            do
            {
                Console.WriteLine("1- Inicializar ");
                Console.WriteLine("2- Agregar Empleados");
                Console.WriteLine("3- Modificar Empleado");
                Console.WriteLine("4- Consultar Empleado");
                Console.WriteLine("5- Borrar Empleado");
                Console.WriteLine("6- Reporte");
                Console.WriteLine("7- Salir");
                Console.WriteLine("8- Ingrese una opcion");
                int.TryParse(Console.ReadLine(), out opcion);

            
                switch (opcion)
                {
                    case 1: Clsempleado.Inicializar(); break;
                    case 2: Clsempleado.Agregar(); break;
                    case 3: Clsempleado.Modificar(Clsempleado.Buscar()); break;
                    case 4: Clsempleado.Consultar(Clsempleado.Buscar()); break;
                    case 5: Clsempleado.Borrar(Clsempleado.Buscar()); break;
                    case 6: Submenu.subreporte(); break;
                    default:
                        Console.WriteLine("caracter no valido");
                        break;
                }
            } while (opcion != 7);

        }
    }
}
    
    

