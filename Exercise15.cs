using System;
using System.Collections.Generic;

namespace ProwayExercises
{
    class ExerciseFifteen
    {
        public static void Show3And5multiples(string[] args){
            Console.WriteLine("\nExercício 15.");
            Console.WriteLine("Ler 10 números e imprimir quantos são múltiplos de 3,");
            Console.WriteLine("e quantos são múltiplos de 5\n");

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Informe o {i + 1}º valor: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> m3 = new List<int>();
            List<int> m5 = new List<int>();

            foreach (int number in numbers) {
                if (number % 3 == 0) m3.Add(number);
                if (number % 5 == 0) m5.Add(number);
            }

            m3.Sort();
            m5.Sort();

            Console.WriteLine($"\nSão múltiplos do número três {m3.Count} números: ");
            foreach (int x in m3) Console.Write($"{x}, ");
            Console.WriteLine($"\n\nSão múltiplos do número cinco {m5.Count} números: ");
            foreach (int y in m5) Console.Write($"{y}, ");
            Console.ReadLine();
        }
    }
}