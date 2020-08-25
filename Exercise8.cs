using System;

namespace ProwayExercises
{
    class ExerciseEight
    {
        public static void CheckMultiple(string[] args)
        {
            Console.WriteLine("\nExercício 8.");
            Console.WriteLine("Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.\n");
            
            Console.WriteLine("Informe o primeiro número");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % n2  == 0) {
                Console.WriteLine($"{n1} é múltiplo de {n2}\n");
            }
            else Console.WriteLine($"{n1} não é múltiplo de {n2}\n");

            Console.ReadLine();
        }
    }
}