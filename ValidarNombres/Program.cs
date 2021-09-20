using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "";


            Console.WriteLine("Ingrese el texto:");
            txt = Console.ReadLine();

            string analizador = txt.ToUpper();

            if (txt != analizador)
            {
                Console.WriteLine("El texto ingresado: {0}, no cumple los requisitos", txt);

            }
            else
            {
                Console.WriteLine("El texto ingresado: {0}, es correcto");
            }
                Console.ReadKey();
        }
    }
}
