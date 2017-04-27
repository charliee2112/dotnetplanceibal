using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        public delegate void Exercise();
        static void Main(string[] args)
        {
            Menu(LoadExercises());
        }

        private static List<Exercise> LoadExercises()
        {
            return new List<Exercise>() {
                Iteraciones.Fibonacci,
                Iteraciones.SumaHastaN,
                Iteraciones.PiramideEstrellas,
                Iteraciones.RomboLoco,
            };
        }

        private static void Menu(List<Exercise> exercises)
        {
            string option = "";
            bool leaving = false;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido a los ejemplos.");
                    exercises.ForEach(x => Console.WriteLine(exercises.IndexOf(x) + "-> " + x.Method.Name));
                    Console.WriteLine("x-> Salir");
                    Console.WriteLine();
                    Console.Write("Por favor seleccione una opcion: ");
                    option = Console.ReadLine();
                    int aux = Convert.ToInt16(option);
                    Console.WriteLine();
                    if (aux > -1 && aux < exercises.Count)
                    {
                        exercises[aux]();
                    }
                    leaving = option.ToString().ToLower().Equals("x");
                    if (!leaving)
                    {
                        Console.WriteLine("Presione cualquier tecla para refrescar el menu");
                        Console.ReadKey();
                    }
                    Console.WriteLine();
                }
                while (!leaving);
            }
            catch (Exception)
            {
                if (!option.ToString().ToLower().Equals("x")) Menu(exercises); //!!
            }
        }
    }
}
