using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("PlanDeCuentas.txt");
            Console.WriteLine("El contenido del archivo = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("\t");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadLine();

        }
    }
}
