using System;

namespace ProwayExercises
{
    class ExerciseThree
    {
        public static void PrintOddNumbers(string[] args)
        {
            Console.WriteLine("\nExercício 3\n");
            Console.WriteLine("Imprimir todos os números ímpares menores de 200");

            for (int i = 1; i < 200; i += 2) {
               Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}