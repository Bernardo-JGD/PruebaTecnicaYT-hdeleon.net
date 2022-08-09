using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaHamming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            yo();
            video();

            Console.ReadLine();
        }

        //Que tan diferentes son 2 cadenas de la misma longitud.
        //Comparar posion i de la primer palabra con la posición y de la segunda
        //y si no son iguales, incrementa la distancia en 1

        static void yo()
        {
            string cadena1 = "murcielago";
            string cadena2 = "murciegalo";
            int distancia = 0;

            if (cadena1.Length != cadena2.Length)
            {
                Console.WriteLine("No tienen el mismo tamaño");
            }
            else
            {
                for (int i = 0; i < cadena1.Length; i++)
                {
                    if (cadena1.ToCharArray()[i] != cadena2.ToCharArray()[i])
                    {
                        distancia++;
                    }
                }
                Console.WriteLine(distancia);
            }

            
        }
    
        static void video()
        {
            string texto1 = "patitosw";
            string texto2 = "paratosa";

            int distancia = 0;

            if (texto1.Length != texto2.Length)
            {
                throw new Exception("Longitudes distintas");
            }
            else
            {
                for (int i = 0; i<texto1.Length; i++)
                {
                    if (texto1[i] != texto2[i])
                    {
                        distancia++;
                    }
                }
            }

            Console.WriteLine("Distancia es de: " + distancia);
        }

    }
}
