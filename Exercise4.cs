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

            int media;
            int t = 0;
            int age;
            int sumAge = 0;
            while(true){
                Console.WriteLine("Informe a idade:");
                age = Convert.ToInt32(Console.ReadLine());
                if(age != 0){
                    sumAge += age;
                    t++;
                    media = sumAge / t;
                    Console.WriteLine($"A média das idades é igual a: {media}");
                }
                else{
                    break;
                }
            }

            Console.WriteLine("******************* \n Fim do exercício 4");
            Console.ReadLine();
        }
    }
}