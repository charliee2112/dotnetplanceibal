using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Iteraciones
    {

        public static void Fibonacci()
        {
            Console.WriteLine("Bienvenido a la Secuencia de Fibonacci!");
            Console.Write("Ingrese la posicion deseada: ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Posicion 0: " + 0);
            Console.WriteLine("Posicion 1: " + 1);

            int primer = 0;
            int segundo = 1;
            int suma = 1;

            for (int i = 2; i < posicion; i++)
            {
                suma = primer + segundo;
                Console.WriteLine("Posicion " + i + ": " + suma);
                primer = segundo;
                segundo = suma;
            }
        }
        
        public static void PiramideEstrellas()
        {
            Console.WriteLine("Aqui tienes una piramide de ejemplo.");
            Console.WriteLine();
            for (int i = 1;i<8;i++)
            {
                Console.Write(new string(' ',8-i));
                Console.Write(String.Concat(Enumerable.Repeat(" *", i)));
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void RomboLoco()
        {
            Console.WriteLine("Aqui tienes una piramide de ejemplo.");
            Console.WriteLine();
            for (int i = 1; i < 8; i++)
            {
                Console.Write(new string(' ', 8 - i));
                Console.Write(String.Concat(Enumerable.Repeat(" *", i)));
                Console.WriteLine();
            }
                        
            for (int i = 8; i > 0; i--)
            {
                Console.Write(new string(' ', 8 - i));
                Console.Write(String.Concat(Enumerable.Repeat(" *", i)));
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void SumaHastaN()
        {
            Console.WriteLine("Bienvenido a la Seccion de sumas de numeros!");
            Console.Write("Ingrese un numero entre 1 y 100: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 && numero <= 100)
            {
                int suma = 0;
                for (int i = 1; i <= numero; i++)
                {
                    suma = suma + i; //+=
                }
                Console.WriteLine("La suma da " + suma);
            }
            else
            {
                Console.WriteLine("Numero no valido");
            }

            /*Solucion ideal:
             Console.WriteLine("Ingrese un numero entre 1 y 100");
             int numero = Convert.ToInt32(Console.ReadLine());

             if (numero >= 1 && numero <= 100)
             {
                 int suma = numero * (numero - 1) / 2;
                 Console.WriteLine("La suma da " + suma);
             }
             else
             {
                 Console.WriteLine("Numero no valido");
             }
            */
        }
    }
}
