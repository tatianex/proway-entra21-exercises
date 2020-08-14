using System;

namespace ProwayExercises
{
    class ExerciseThirteen
    {
        public static void ShowBiggestValue(string[] args){
            Console.WriteLine("\nExercício 13.");
            Console.WriteLine("Ler 10 valores e determinar o maior entre eles.\n");

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Informe o {i + 1}º valor: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int biggestNumber = int.MinValue;

            foreach (int number in numbers) {
                if (number > biggestNumber) biggestNumber = number;
            }

            Console.WriteLine($"\nO maior número entre os dez é o {biggestNumber}\n");
            Console.ReadLine();
        }
    }
}