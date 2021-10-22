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
            // Pedimos el nombre y lo separamos en 3 con el split.
            Console.WriteLine("Ingrese un nombre: (EJj: 'Edgar Alan Poe')");
            string cadena = Console.ReadLine();
            ValidarNombre nombreFinal = new ValidarNombre();
            Console.WriteLine(nombreFinal.ValidarTodo(cadena));

            Console.ReadKey();
        }
    }

    class ValidarNombre
    {

        public string ValidarTodo(string cadena)
        {
            var nom1 = "";
            var nom2 = "";
            var nom3 = "";

            string[] nombre = cadena.Split(' ');
            // Tenemos los 3 nombres separados listos para evaluarlos.
            if (nombre.Length < 2)
            {
                return "Por favor, ingresar al menos 2 términos.";
            }
            else
            {
                if (nombre.Length <= 2)
                {
                    nom1 = nombre[0];
                    nom2 = nombre[1];
                    nom3 = "";

                }
                else
                {
                    nom1 = nombre[0];
                    nom2 = nombre[1];
                    nom3 = nombre[2];
                }
            }

            if (nom1.Length == 1)
            {
                return "El primer nombre no es valido ya que es muy pequeño o no cuenta como abreviacion al no incluir '.'.";
            }
            if (nom2.Length == 1)
            {
                return "El segundo nombre no es valido ya que es muy pequeño o no cuenta como abreviacion al no incluir '.'.";
            }
            if (nom3.Length == 1)
            {
                return "El apellido no es valido ya que es muy pequeño.";
            }

            if (ValidadorMayusculas(nom1, nom2, nom3) == "ok")
            {
                if (ValidadorLargoYPunto(nom1, nom2, nom3) != "ok")
                {
                    return "Nombre no valido.";
                }
            }
            else
            {
                return "Nombre no valido.";
            }



            return "El nombre es valido";
        }

        public string ValidadorMayusculas(string PrimerNombre, string SegundoNombre, string Apellido)
        {

            // Aca evalua si el primer nombre empieza con mayuscula o no.
            string mayusPrimerNombre = PrimerNombre.Substring(0, 1).ToUpper();

            if (PrimerNombre.Substring(0, 1) != mayusPrimerNombre && PrimerNombre.Length != 2)
            {
                return "El primer nombre es incorrecto, debe empezar con mayusculas y solo puede contener 1 letra.";
            }

            // Aca evalua si el segundo nombre empieza con mayuscula o no.
            string mayusSegundoNombre = SegundoNombre.Substring(0, 1).ToUpper();

            if (SegundoNombre.Substring(0, 1) != mayusSegundoNombre && SegundoNombre.Length != 2)
            {
                return "El segundo nombre es incorrecto, debe emplezar con mayusculas.";
            }

            // Aca evalua si el  apellido empieza con mayuscula o no.
            if (Apellido != "")
            {
                string mayusApellido = Apellido.Substring(0, 1).ToUpper();
                if (Apellido.Length <= 2)
                {
                    return "El apellido no puede ser abreviado.";
                }
                else
                {
                    if (Apellido.Substring(0, 1) != mayusApellido)
                    {
                        return "El apellido es incorrecto, debe empezar con mayusculas";
                    }

                }

            }
            return "ok";
        }

        public string ValidadorLargoYPunto(string PrimerNombre, string SegundoNombre, string Apellido)
        {
            // Recorremos el primer nombre buscando el '.' y evaluamos el largo del string para saber si es una palabra con punto o una letra con punto.
            string mayusculaPrimerNombre = PrimerNombre.Substring(0, 1).ToUpper();
            for (int i = 0; i < PrimerNombre.Length; i++)
            {

                string n = PrimerNombre.Substring(i);
                if (n == ".")
                {
                    if (PrimerNombre.Length > 2)
                    {
                        return " En el primer nombre las abreviaciones solo pueden ser de una letra y un punto. EJ: 'S. Manuel Llanes'.";
                    }
                    else
                    {
                        if (PrimerNombre.Substring(0, 1) != mayusculaPrimerNombre)
                        {
                            return "El primer nombre es incorrecto.";
                        }
                    }
                }

            }

            // Recorremos el segundo nombre buscando el '.' y evaluamos el largo del string para saber si es una palabra con punto o una letra con punto.
            for (int i = 0; i < SegundoNombre.Length; i++)
            {
                string puntito = SegundoNombre.Substring(i);

                if (puntito == ".")
                {
                    if (SegundoNombre.Length > 2)
                    {
                        return "En el segundo nombre las abreviaciones solo pueden ser de una letra y un punto. EJ: 'S. M. Llanes'.";
                    }
                }
            }

            // Recorremos el apellido buscando el '.' lo cual no esta permitido en los apellidos.
            for (int i = 0; i < Apellido.Length; i++)
            {
                string puntito = Apellido.Substring(i);

                if (puntito == ".")
                {
                    return "Los apellidos no pueden ser abreviados";
                }
            }
            return "ok";
        }
    }
}

