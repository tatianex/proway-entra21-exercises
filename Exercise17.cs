using System;

namespace ProwayExercises
{
    class ExerciseSeventeen
    {
        public static void PrintMultiplicationTable(string[] args){
            Console.WriteLine("\nExercício 17.");
            Console.WriteLine("Imprimir a tabuada de qualquer número fornecido pelo usuário");
            Console.WriteLine("até que o usuário forneça o valor –1.\n");

            int option = 0;

            while (option != -1 ) {

                Console.WriteLine("\nInforme o número do qual você gostaria de saber a tabuada: ");
                Console.WriteLine("Informe -1 para sair");

                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                int sum = 0;
                for (int i = 1; i < 11; i++) {
                    sum = option * i;
                    Console.WriteLine($"Tabuada de {option} x {i} = {sum}");
                }
            }
        }
    }
}