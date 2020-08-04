using System;

namespace ProwayExercises
{
    class ExerciseFourteen
    {
        public static void SortValues(string[] args){
            Console.WriteLine("\nExercício 14.");
            Console.WriteLine("Ler três valores e colocá-los em ordem\n");

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"Informe o {i + 1}º valor: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("\n");

            foreach (int number in numbers) {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}