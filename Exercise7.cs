using System;

namespace ProwayExercises
{
    class ExerciseSeven
    {
        public static void CalculateMoneySpentBySmoker(string[] args)
        {
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 7.",
                "Calcular a quantidade de dinheiro gasta por um fumante.",
                "Dados: o número de anos que ele fuma,",
                "o nº de cigarros fumados por dia e o preço de uma carteira. \n\n"
            ));
            Console.WriteLine("Informe há quantos anos a pessoa fuma");
            int yearsSmoking = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de cigarros fumados por dia");
            int cigarettes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor que você geralmente paga pela carteira de cigarro");
            double cigarettesPrice = Convert.ToDouble(Console.ReadLine());

            int totalCigarettesInBox = 20;
            var totalDaysSmoking = yearsSmoking * 365;
            var totalCigarrettesSmoked = cigarettes * totalDaysSmoking;
            var totalBoxesSmoked = totalCigarrettesSmoked / totalCigarettesInBox;
            var totalValueSpended = totalBoxesSmoked * cigarettesPrice;
            
            Console.WriteLine(String.Join(
                Environment.NewLine,
                $"A quantidade de dias fumados é de {String.Format(@"{0:0,0}", totalDaysSmoking)} dias",
                $"O total de cigarros fumados é de {String.Format(@"{0:0,0}", totalCigarrettesSmoked)}.",
                $"Foram fumadas {String.Format(@"{0:0,0}", totalBoxesSmoked)} carteiras de cigarro.",
                $"E o valor gasto com {String.Format(@"{0:0,0}", totalBoxesSmoked)} carteiras de cigarro",
                $"ao longo de {String.Format(@"{0:0,0}", totalDaysSmoking)} dias ou {yearsSmoking} anos foi de {String.Format(@"{0:c}", totalValueSpended)}\n"
            ));

            Console.ReadLine();
        }
    }
}