using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yo();
            video();

            Console.ReadLine();
        }

        static void yo()
        {
            string cadena = "Cadena al derecho";
            string resultado = "";

            for (int i = cadena.Length; i>0; i--)
            {
                resultado += Convert.ToString(cadena.ToCharArray()[i-1]);
            }
            


            Console.WriteLine(resultado);
        }
    
        static void video()
        {
            string cadena = "Cadena al derecho";
            string resultado = "";
            /*Sugerencia del video para el ciclo
            for(int i = cadena.Length-1; i>=0; i--){
                resultado += cadena[i];
            }
             */
            char[] chars = cadena.ToCharArray();
            Array.Reverse(chars);
            resultado = new string(chars);

            Console.WriteLine(resultado);
        }

    }
}
