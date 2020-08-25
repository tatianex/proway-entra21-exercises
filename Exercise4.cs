using System;

namespace ProwayExercises
{
    class ExerciseFour
    {
        public static void CalculateAgeMedia(string[] args)
        {
            Console.WriteLine("\nExercício 4");
            Console.WriteLine("Calcular a média de idade de uma turma qualquer. ");
            Console.WriteLine("O algoritmo deve parar quando for digitada a idade igual a zero.");

            double media;
            int t = 0;
            double age;
            double sumAge = 0;

            while (true) {
                Console.WriteLine("Informe a idade:");
                age = Convert.ToDouble(Console.ReadLine());
                if (age != 0){
                    sumAge += age;
                    t++;
                    media = (sumAge / t);
                    Console.WriteLine($"A média das idades é igual a:{String.Format(@"{0,6:N2}", media)}");
                }
                else break;
            }
            Console.ReadLine();
        }
    }
}