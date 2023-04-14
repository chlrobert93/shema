using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Clase StreamReader
            /*   try
               {
                   using (StreamReader leer = new StreamReader("c:/prueba.txt"))
                   {
                       string linea;

                       while ((linea = leer.ReadLine()) != null)
                       {
                           Console.WriteLine(linea);
                       }
                   }
               }
               catch (Exception e)
               {
                   Console.WriteLine("Se ha producido una excepción");
                   Console.WriteLine(e.Message);
               }
               Console.ReadKey();*/

            // Clase StreamWriter

            string[] nombres = new string[] { "Ángel Arias", "Patricia Gonzalez" };

            using (StreamWriter escribir = new StreamWriter("c:/nombres.txt"))
            {
                foreach (string nombre in nombres)
                {
                    escribir.WriteLine(nombre);
                }
            }

            using (StreamReader leer = new StreamReader("c:/nombres.txt"))
            {
                string linea;

                while ((linea = leer.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            Console.ReadKey();
        }
    }
}
