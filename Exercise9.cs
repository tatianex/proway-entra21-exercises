using System;

namespace ProwayExercises
{
    class ExerciseNine
    {
        public static void CheckTheBiggestNumber(string[] args)
        {
            Console.WriteLine("\nExercício 9.");
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "Fazer um algoritmo para ler 3 números reais do teclado",
                "e verificar se o primeiro é maior do que a soma dos outros dois. \n"
            ));
            
            Console.WriteLine("Informe o primeiro número");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > (n2 + n3)){
                Console.WriteLine("O primeiro número é maior do que a soma o 2º e o 3º\n");
            }
            else Console.WriteLine("O primeiro número não é maior do que a soma do 2º e o 3º\n");
            
            Console.ReadLine();
        }
    }
}