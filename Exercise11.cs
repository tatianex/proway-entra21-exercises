using System;

namespace ProwayExercises
{
    class ExerciseEleven
    {
        public static void SplitNumbers(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 11.",
                "Ler 2 números inteiros do teclado. Se o segundo for diferente de zero,",
                "calcular e imprimir o quociente do primeiro pelo segundo.",
                "Caso contrário imprimir a mensagem \"DIVISÃO POR ZERO\""
            ));

            Console.WriteLine("Informe o primeiro número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b != 0){
                int c = a / b;
                Console.WriteLine($"{a} dividido por {b} é igual a: {c}\n");
            }
            else Console.WriteLine("DIVISÃO POR ZERO \n");

            Console.ReadLine();
        }
    }
}