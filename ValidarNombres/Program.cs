using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidarNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            var nom1 = "";
            int cantLetras1 = 0;
            var nom2 = "";
            int cantLetras2 = 0;
            var nom3 = "";
            int cantLetras3 = 0;

            Console.WriteLine("Ingrese un nombre: (EJj: 'Edgar Alan Poe')");
            string cadena = Console.ReadLine();

            string[] nombre = cadena.Split(' ');

            foreach (var n in nombre[0])
            {
                if (n != ' ')
                {
                    cantLetras1 = cantLetras1 + 1;
                    nom1 += n;
                }
            }

            char a = '.';
            foreach (var n in nombre[0])
            {
                if (n != '.')
                {
                }
                else
                {
                     a = n;
                }
            }


            foreach (var n in nombre[1])
            {
                if (n != ' ')
                {
                    cantLetras2 = cantLetras2 + 1;
                    nom2 += n;
                }
            }
            char b = '.';
            foreach (var n in nombre[1])
            {
                if (n != '.')
                {
                }
                else
                {
                     b = n;
                }
            }

            foreach (var n in nombre[2])
            {
                if (n != ' ')
                {
                    cantLetras3 = cantLetras3 + 1;
                    nom3 += n;
                }
            }

            char c = '.';
            foreach (var n in nombre[2])
            {
                if (n != '.')
                {
                }
                else
                {
                    c = n;
                }
            }

            if (cantLetras1 > 2 & a != '.')
            {
                Console.WriteLine("El primer nombre: {0}, es correcto", nom1);
            }
            else
            {
                Console.WriteLine("El primer nombre: {0}, es incorrecto", nom1);
            }

            if (cantLetras1 == 2 & a ==  '.')
            {
                Console.WriteLine("El primer nombre: {0}, es correcto", nom1);
            }



            Console.ReadKey();
        }
    }




}

