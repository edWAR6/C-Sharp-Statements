using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un coracter:");
            char c = (char)Console.Read();

            // Condición tipo if
     
            if (Char.IsLetter(c)) {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("El caracter es minúscula.");
                }
                else
                {
                    Console.WriteLine("El caracter es mayúscula.");
                }
            }
            else
            {
                Console.WriteLine("El caracter no es una letra.");
            }

            Console.ReadKey();
        }
    }
}
