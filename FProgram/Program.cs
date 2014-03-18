using System;
using System.Collections.Generic;
using System.Text;


namespace FProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leer una cadena y transformar a lenguaje 'F'
             * Suposiciones la cadena de entrada esat dada en minusculas
             * 
             * Ejemplo Hola Mundo¡ => Hofolafa Mufundofo¡
             * 
             * Entrada 
             *      cadena input
             *      entero index,cinterno
             *      cadena Vocales
             * Proceso
             *      caracter cActual
             *      cadena expresion
             * Salida
             *      cadena resultado
             *      
             * 05   Hacer Vocales= "aeiou"
             * 10   Escribe "Dame una cadena"
             * 20   Leer input
             * 30   hacer index=0
             * 40   si index < input.lenght
             * 41       cinterno = 0
             * 50       cActual = input[index]
             * 55       expresion = cActual
             * 60       si cActual = vocales[cinterno]
             * 70           expresion= cActual + "f" } cActual;
             * 75           cinterno = cinterno + 1
             * 76           ir a L60
             * 80       resultado = resultado + expresion
             * 90       index = index +1
             * 100      ir a L40
             * 101  Escribe input Escribe " en lenguaje F es " Escribe resultado
             */

            //ENTRADA
            string input, vocales;
            int index, cinterno;
            //PROCESO
            char cActual;
            string expresion;
            //SALIDA
            StringBuilder resultado = new StringBuilder();

            vocales = "aeiou";

            Console.Write("Dame una cadena _");
            input = Console.ReadLine();
            index = 0;
        L40:
            if (index < input.Length)
            {
                cinterno = 0;
                cActual = input[index];
                expresion = cActual.ToString();
            L60:
                if (cinterno < 5)
                {
                    if (cActual == vocales[cinterno])
                    {
                        expresion = cActual + "f" + cActual;
                        goto L70;
                    }
                    if (cActual != vocales[cinterno])
                    {
                        cinterno = cinterno + 1;
                        goto L60;
                    }
                }

            L70:
                resultado.Append(expresion);
                index = index + 1;
                goto L40;
            }

            Console.WriteLine("{0} en lenguaje F es {1} ", input, resultado);

            Console.WriteLine("Presione <enter> para continuar");
            Console.ReadLine();
        }
    }
}
