using System;

namespace ProwayExercises {
    class ExerciseOne {
        public static void PrintNumbers(string[] args)
        {
            Console.WriteLine("\nExercício 1\n");
            Console.WriteLine("1.A Imprimir os números de 1 a 10 de forma crescente\n");

            for (int a = 1; a < 11; a++) {
                Console.Write($"{a} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("1.B Imprimir os números de 1 a 10 de forma decrescente\n");

            for (int b = 10; b > 0; b--) {
                Console.Write($"{b} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("1.C Imprimir os números de 1 a 10 de forma crescente, mas apenas aqueles que forem pares\n");

            for (int c = 1; c < 11; c++) {
                if (c % 2 == 0) {
                    Console.Write($"{c} ");
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("1.D Imprimir os números de 10 a 1 de forma decrescente, mas apenas aqueles que forem ímpares\n");
            // outra forma de imprimir de dois em dois sem usar '%' resto

            for (int d = 9; d > 0; d-=2) {
                Console.Write($"{d} ");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}