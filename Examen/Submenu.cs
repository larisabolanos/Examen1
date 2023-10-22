using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Submenu
    {

        static public void subreporte()
        {
            int opcion = 0;
           
             do
            {
                
                Console.WriteLine("1 Consultar empleados");
                Console.WriteLine("2 Listar los empleados");
                Console.WriteLine("3 Calcular y mostrar el promedio de salarios");
                Console.WriteLine("4 Calcular el salario mas bajo y alto");
                Console.WriteLine("Digite una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Console.WriteLine("Consultar"); break;
                    case 2: Console.WriteLine("Lista"); break;
                    case 3: Console.WriteLine("Promedio de trabajos"); break;
                    case 4: Clsempleado.Salarioaltoybajo(); break;
                    case 5: Submenu.subreporte(); break;
                    default:
                        Console.WriteLine("caracter no valido");
                        break;




                }
            } while (opcion!=3);


        }
    }
}
