using System;

namespace ProwayExercises {
    class ExerciseOne {
        public static void PrintNumbers(string[] args)
        {
            Console.WriteLine("\nExercício 1");
            Console.WriteLine("1.A Imprimir os números de 1 a 10 de forma crescente\n");

            for(int a = 1; a < 11; a++){
                Console.WriteLine(a);
            }

            Console.WriteLine("\n******************* \n");

            Console.WriteLine("1.B Imprimir os números de 1 a 10 de forma decrescente\n");

            for(int b = 10; b > 0; b--){
                Console.WriteLine(b);
            }

            Console.WriteLine("\n******************* \n");

            Console.WriteLine("1.C Imprimir os números de 1 a 10 de forma crescente, mas apenas aqueles que forem par\n");

            for(int c = 1; c < 11; c++){
                if(c % 2 == 0){
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine("\n******************* \n");
            Console.ReadLine();
        }
    }
}