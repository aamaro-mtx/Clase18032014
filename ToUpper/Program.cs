using System;
using System.Text;

namespace ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada
            string input;
            int index = 0, contador = 0;

            //proceso
            int valCarAct;
            char ctmp;

            //salida 
            StringBuilder sb = new StringBuilder();
            string stringFinal = "";

            //10 Escribe “Dame una cadena”
            Console.WriteLine("Dame una cadena");

            //20 Leer input
            input = Console.ReadLine();
        L30:
            //30 si index < input.Length
            if (index < input.Length)
            {
                // 40 hacer ctmp= input[index]
                ctmp = input[index];
            Lreduce:
                //41 Si contador < 32
                if (contador < 32)
                {
                    //42 ctmp= ctmp - 1;
                    ctmp--;
                    //43 hacer contador = contador + 1;
                    contador = contador + 1;
                    goto Lreduce;
                }
                //43 hacer contador = 0
                contador = 0;
                //50	resultado = resultado + actual
                sb.Append(ctmp);

                //60	index = index + 1
                index = index + 1;
                //70	Ir a L30
                goto L30;
            }

            //80 Escribe “La cadena resultante es ” Escribe resultado
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Presione <enter> para continuar");
            Console.ReadLine();
        }
    }
}
