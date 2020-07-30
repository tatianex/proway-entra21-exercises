using System;

namespace ProwayExercises
{
    class ExerciseSixteen
    {
        public static void CalculateIncomeTax(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 16.",
                "Ler o salário de uma pessoa e imprimir o Salário Líquido",
                "de acordo com a redução de imposto descrito ao lado:",
                "Menor ou igual a R$600,00 - ISENTO;",
                "Maior que R$600,00 e menor ou igual a R$1.000,00 - 20% desconto;",
                "Maior que R$1.200,00 e menor ou igual a R$2.000,00 - 25% desconto;",
                "Maior que R$2.000,00 - 30% desconto"
            ));

            Console.WriteLine("Informe o seu salário");
            double salary = Convert.ToDouble(Console.ReadLine());

            double discount1 = (salary - ((salary * 20) / 100));
            double discount2 = (salary - ((salary * 25) / 100));
            double discount3 = (salary - ((salary * 30) / 100));

            if (salary <= 600) {
                Console.WriteLine($"Você está ISENTO do IRRF. Seu salário líquido é de: {String.Format(@"{0:c}", salary)}");
            }
            else if (salary <= 1200) {
                Console.WriteLine($"Você tem desconto de 20% no IRRF. Seu salário líquido é de: {String.Format(@"{0:c}", discount1)}");
            }
            else if (salary <= 2000) {
                Console.WriteLine($"Você tem desconto de 25% no IRRF. Seu salário líquido é de: {String.Format(@"{0:c}", discount2)}");
            }
            else Console.WriteLine($"Você tem desconto de 30% no IRRF. Seu salário líquido é de: {String.Format(@"{0:c}", discount3)}");

            Console.ReadLine();
        }
    }
}