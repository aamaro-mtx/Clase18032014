using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You shall never \nwalk alone");
            
            Console.WriteLine("Dame una cadena :");
            string cadena = Console.ReadLine();
            int numCar = cadena.Length;
            if (numCar < 1)
            {
                Console.WriteLine("La cadena debe de tener al menos un caracter");
                return;
            }
            StringBuilder sb = new StringBuilder();
            int index = 0;
            do
            {
                char actual = cadena[index];

                char anterior = cadena[index - 1];
                if (actual != ' ')
                {
                    sb.Append(cadena[index]);
                }
                else if (anterior == ' ')
                {
                    sb.Append(cadena[index]);
                }
                index++;

            } while (index != numCar);
            Console.WriteLine("Resultado {0}", sb);

            Console.WriteLine("Presione <enter> para continuar");
            Console.ReadLine();


        }
    }
}
