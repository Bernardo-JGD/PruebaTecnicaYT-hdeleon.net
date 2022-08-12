using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContadorPalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yo();
            //yo2();
            video1();
            Console.ReadLine();
        }

        static void yo()
        {
            string oracion = "Texto que contiene cinco palabras ";
            int contador = 0;
            for (int i = 0; i<oracion.Length; i++)
            {
                if (oracion.ToCharArray()[i] == ' ')
                {
                    contador++;
                }
            }
            if (oracion.ToCharArray()[oracion.Length-1] != ' ')
            {
                contador++;
            }
            Console.WriteLine(contador);

        }

        static void yo2()
        {
            string oracion = "Texto    que contiene    cinco palabras   ";
            string palabra = "";
            List<string> palabras = new List<string>();
            int contador = 0;
            for (int i = 0; i < oracion.Length; i++)
            {
                if (oracion.ToCharArray()[i] != ' ')
                {
                    palabra += Convert.ToString(oracion.ToCharArray()[i]);
                }
                else
                {
                    contador++;
                    Console.WriteLine(palabra);
                    palabras.Add(palabra);
                    palabra = "";
                }
            }

            Console.WriteLine(palabras.Count);
        }

        static void video1()
        {
            string oracion = "Texto que contiene cinco palabras";
            /*Podemos contarlas separadas por espacios con el método split*/
            int n = 0;
            var words = oracion.Split(' ');
            n = words.Length;
            Console.WriteLine("Video op 1: " + n);

            //¿Pero si tiene espacios al final o al principio?
            oracion = "  Texto que contiene cinco palabras  ";
            /*Le decimos que la oracion va a ser igual a la oración pero
             sin espacios al principio o al final*/
            oracion = oracion.Trim();
            words = oracion.Split(' ');
            n = words.Length;
            Console.WriteLine("Video op 2: " + n);

            /*¿Pero si tuviera espacios en todas partes?*/
            oracion = "  Texto    que  contiene    cinco     palabras     ";

            oracion = Regex.Replace(oracion, @"\s+", " ").Trim();
            /* @"\s+" ---- Quita uno o más espacios entre las palabras
             y trim quita los espacios de los extremos*/
            words = oracion.Split(' ');
            n = words.Length;
            Console.WriteLine("Solucion con regex: " + n);
        }

    }
}
