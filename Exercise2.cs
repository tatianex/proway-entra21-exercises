using System;

namespace ProwayExercises
{
    class ExerciseTwo
    {
        public static void SumIntNumbers(string[] args)
        {

            Console.WriteLine("\nExercício 2");
            Console.WriteLine("Imprimir a soma dos números inteiros de 1 a 100");
            int sum = 0;
            for(int x = 1; x < 101; x++){
                sum += x;
            }
            Console.WriteLine($"A soma dos números inteiros de 1 a 100 é de: {sum}");
            Console.WriteLine("******************* \nFim do exercício 2\n");
            Console.ReadLine();
        }
    }
}
