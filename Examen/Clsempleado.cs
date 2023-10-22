using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Clsempleado
    {

        // Atributos
       public static  int cantidad = 10;
        static byte indice;
        

        static int pos = 1;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] direccion = new string[cantidad];
        static public string[] Telefono = new string[cantidad];
        static public float[] Salario = new float[cantidad];



        // Constructor
        public  Clsempleado()
        {
            int cantidad = 0;
            byte indice;
           
                pos = 1;
        }


        // metodos

        public static void Inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("",cantidad).ToArray();
            Telefono = Enumerable.Repeat("", cantidad).ToArray();
            Salario = Enumerable.Repeat(0f,10).ToArray();
            Console.WriteLine("Arreglos inicializados");
          
        }
        public static void ReporteGeneral()
        {
            Console.WriteLine($"*****Cantidad de cedulas*****");
            for(int i = 0;i < cantidad; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]} Salario: {Salario[i]}");
             }
            Console.WriteLine($"*****Fin de cedulas*****");
        }

        public static void Consulta()
        {
            Console.Clear();
            Console.WriteLine("Digite la cedula");
            string id=Console.ReadLine();
            Boolean encontro = false;
            for(int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {

                    Console.WriteLine($"Cedula: {cedula[i]} Salario: {Salario[i]}");
                    encontro = true;
                    break;
                       }
            }
            if(encontro==false)


  
                {
                    Console.WriteLine(" no existe");

                }
            }

        
        public static void Agregar()
        {
            char respuesta;
            do
            {

                Console.Clear();
                Console.Write($"Ingrese la cedula({pos})");
                cedula[indice] = Console.ReadLine();
                Console.Write($"Ingrese el nombre({pos})");
                nombre[indice] = Console.ReadLine();
                Console.Write($"Ingrese la Telefono({pos})");
                Telefono[indice] = Console.ReadLine();
                Console.Write($"Ingrese la direccion({pos})");
                direccion[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese el salario ({pos}) ");
                Salario[indice] = float.Parse(Console.ReadLine());
                Console.WriteLine("Desea ingresar otro usuario (S/N");
                respuesta = char.Parse(Console.ReadLine().ToLower());
                switch (respuesta)
                {
                    case 's': indice++; pos++; break;
                    case 'n':break;
                        Console.WriteLine("Opcion incorrecta");
                        respuesta = 'n';
                        break;
                }


                indice++;
                pos++;
            } while (!respuesta.Equals('n'));

            indice++;

        }




        public static void Consultar(string id)
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write($"Nombre: {nombre[i]}");
                    Console.Write($"direccion: {direccion[i]}");
                    Console.Write($"cedula: {cedula[i]}");
                    
                    break;
                }
            }
        }

        public static string Buscar()
        {
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            return ced;
        }

        public static void Lista()
        {

        }
        public static void  Salarioaltoybajo()
        {
           
            int MAY, MEN, NUM;
            

 string linea;
          
            
            Console.Write("DIGITE EL SALARIO MAS ALTO:"); linea = Console.ReadLine();
            MAY = int.Parse(linea);
            MEN = MAY;
         
            {
                Console.Write("DIGITE EL SALARIO MAS BAJO:"); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                if (NUM > MAY) MAY = NUM;
                if (NUM < MEN) MEN = NUM;
            }
            Console.WriteLine("EL MAYOR ES : " + MAY);
            Console.WriteLine("EL MENOR ES : " + MEN);

        }
    


        
    

    public static void Modificar(string id)
        {

            for (int i = 0; i < cantidad; i++)
            {
                if (id.Equals(cedula[i]))
                {
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite la direccion: ");
                    direccion[i] = Console.ReadLine();
                    Console.Write("Digite la Telefono: ");
                    Telefono[i] = Console.ReadLine();
                    Console.Write("Digite la cedula: ");
                    cedula[i] = Console.ReadLine();
                    Console.Write("Digite la Salario: ");
                    
                    break;
                }
            }
        }
        public static void Borrar(string id)
                {

            List<int> list = new List<int> { 2, 5, 1, 2, 4 };
            List<int> toRemove = new List<int> { 2, 5 };

            List<int> result = list.Except(toRemove).ToList();

            Console.WriteLine(String.Join(", ", result));
            Console.Write("Eliminado");
        }
    }

}



























