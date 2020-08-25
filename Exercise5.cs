using System;

namespace ProwayExercises
{
    class ExerciseFive
    {
        public static void AskAgeInformAveragePercentage(string[] args)
        {
            Console.WriteLine("\nExercício 5");
            Console.WriteLine("Criar um algoritmo que peça o nome e a idade de 5 mulheres.");
            Console.WriteLine("Após informar estes dados, o programa deve mostrar apenas % de mulheres que estão com idade entre 18 e 35");

            string[] name = new string[5];
            int[] age = new int[5];
            for (int i = 0; i < 5; i++){
                Console.WriteLine("Informe o nome dela: ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Informe sua idade: ");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            int groupWomem = 0;
            foreach(int a in age){
                if ((a > 17) && (a < 36)){
                    groupWomem++;
                }
            }
            double percentageWomem = 0D;
            Console.Write($"Existem {groupWomem} mulheres entre 18 e 35 anos.\n");
            percentageWomem = ((Convert.ToDouble(groupWomem) / 5) * 100);
            Console.WriteLine($"A porcentagem de mulheres maiores de 18 e menores de 35 anos é de: {percentageWomem} %\n");
            Console.ReadLine();
        }
    }
}