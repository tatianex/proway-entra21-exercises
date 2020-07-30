using System;

namespace ProwayExercises
{
    class ExerciseEighteen
    {
        public static void CalculatePriceOfApples(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 18.",
                "As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia.",
                "R$1,00 se forem compradas pelo menos 12.",
                "Escreva um programa que leia o número de maçãs compradas,",
                "calcule e escreva o custo total da compra."
            ));

            Console.WriteLine("\n12 Maçãs custam R$1,00. Se levar menos de uma dúzia sai por R$1,30");
            Console.WriteLine("Informe quantas maçãs gostaria de levar");
            int apples = Convert.ToInt32(Console.ReadLine());

            double result = 0.0d;

            if (apples < 12) {
                result = apples * 1.30d;
                Console.WriteLine($"O custo total da compra é de: {String.Format(@"{0:c}", result)}");
            }
            else {
                result = apples * 1.0d;
                Console.WriteLine($"O custo total da compra é de: {String.Format(@"{0:c}", result)}");
            }
            Console.ReadLine();
        }
    }
}