using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterRepetido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yo();
            video1();
            Console.ReadLine();
        }

        static void yo()
        {
            string cadena = "Es probable que esta cadena tenga muchos caracteres repetidos";
            char caracter = 'a';

            int repeticion = 0;
            for (int i = 0; i<cadena.Length; i++)
            {
                if (cadena.ToCharArray()[i] == 'a')
                {
                    repeticion++;
                }
            }
            Console.WriteLine(repeticion);
        }

        static void video1()
        {
            string cadena = "Es probable que esta cadena tenga muchos caracteres repetidos";
            char caracter = 'a';

            int n = 0;

            foreach (var c in cadena)
            {
                if (c == caracter)
                {
                    n++;
                }
            }
            Console.WriteLine(n);
            //Otra forma sería
            n = cadena.Where(c => c == caracter).Count();
            Console.WriteLine(n);
        }

    }
}
