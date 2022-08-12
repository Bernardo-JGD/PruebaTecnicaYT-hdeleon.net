using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yo();/*Puros números*/
            video();
            Console.ReadLine();
        }

        static void yo()
        {
            string cadena = "asdf12314saadsq34zadfa234afdga2134";
            int contador = 0;
            for (int i = 0; i<cadena.Length; i++)
            {
                if (cadena.ToCharArray()[i] >= '0' && cadena.ToCharArray()[i] <= '9')
                {
                    contador++;
                }
            }
            Console.WriteLine("Mi solucion: " + contador);
        }

        static void video()
        {
            string cadena = "123asd567ZXC";
            /*Podemos utilizar expresiones regulares paras encontrar los números*/

            string pattern = @"[0-9]";
            var regex = new Regex(pattern);
            int n = regex.Matches(cadena).Count;

            Console.WriteLine("Numeros encontrados: " + n);

            /*Podemos encontrar todas las letras minúsculas también con regex*/
            pattern = @"[a-z]";
            regex = new Regex(pattern);
            n = regex.Matches(cadena).Count;
            Console.WriteLine("Minúsculas encontradas: " + n);

            /*Podemos encontrar todas las minúsculas y mayúsculas juntas*/
            pattern = @"[a-zA-Z]";
            regex = new Regex(pattern);
            n = regex.Matches(cadena).Count;
            Console.WriteLine("Minúsculas y mayúsculas: " + n);

        }

    }
}
