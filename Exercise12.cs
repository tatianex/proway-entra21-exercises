using System;

namespace ProwayExercises
{
    class ExerciseTwelve
    {
        public static void SumOddAndEvenNumbers(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 12.",
                "Ler quatro números inteiros e calcular a soma dos que forem pares e ímpares"
            ));

            int sumEven = 0;
            int sumOdd = 0;

            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++) {
                Console.WriteLine($"Informe o {i + 1}º número: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers) {
                if (number % 2 == 0) sumEven += number;
                else sumOdd += number;
            }

            Console.WriteLine($"A soma dos números pares é igual a: {sumEven}\n");
            Console.WriteLine($"A soma dos números ímpares é igual a: {sumOdd}\n");
            Console.ReadLine();
        }
    }
}