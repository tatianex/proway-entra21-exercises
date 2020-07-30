using System;

namespace ProwayExercises
{
    class ExerciseTen
    {
        public static void CheckTheBiggestAndEqualNumbers(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 10.",
                "Ler 02 números reais do teclado (A e B),",
                "verificar e imprimir qual deles é maior, ",
                "ou a mensagem \"A = B\" caso sejam iguais. \n"
            ));

            Console.WriteLine("Informe o primeiro número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b) Console.WriteLine("Os números informados são iguais. \n");
            else if (a > b) Console.WriteLine("O primeiro número é maior do que o segundo \n");
            else Console.WriteLine("O segundo número é maior do que o primeiro \n");

            Console.ReadLine();
        }

    }

}