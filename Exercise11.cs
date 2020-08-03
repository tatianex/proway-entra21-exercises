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
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Informe o segundo número");
            string secondNumber = Console.ReadLine();
            int a;
            int b;

            try {
                a  = Int32.Parse(firstNumber);
                b = Int32.Parse(secondNumber);
                if (b != 0){
                int c = a / b;
                Console.WriteLine($"{a} dividido por {b} é igual a: {c}\n");
                }
                else Console.WriteLine("DIVISÃO POR ZERO \n");
            }
            catch (System.Exception) {
                Console.WriteLine("Algum dos números deve estar em formato errado. Tente novamente");
            }

            Console.ReadLine();
        }
    }
}