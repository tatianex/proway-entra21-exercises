using System;

namespace ProwayExercises {
    class MenuExercises {
        static void Main (string[] args)
        {
            int choice = 0;

            while (true) {

                Console.WriteLine("\nEste projeto contém 18 Exercícios. \nDigite um número para ver a solução. \nDigite 0 para sair.\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:
                        ExerciseOne.PrintNumbers(null);
                        break;
                    case 2:
                        ExerciseTwo.SumIntNumbers(null);
                        break;
                    case 3:
                        ExerciseThree.PrintOddNumbers(null);
                        break;
                    case 4:
                        ExerciseFour.CalculateAgeMedia(null);
                        break;
                    case 5:
                        ExerciseFive.AskAgeInformAveragePercentage(null);
                        break;
                    case 6:
                        ExerciseSix.ElectronicBallotBox(null);
                        break;
                    case 7:
                        ExerciseSeven.CalculateMoneySpentBySmoker(null);
                        break;
                    case 8:
                        ExerciseEight.CheckMultiple(null);
                        break;
                    case 9:
                        ExerciseNine.CheckTheBiggestNumber(null);
                        break;
                    case 10:
                        ExerciseTen.CheckTheBiggestAndEqualNumbers(null);
                        break;
                    case 11:
                        ExerciseEleven.SplitNumbers(null);
                        break;
                    case 12:
                        ExerciseTwelve.SumOddAndEvenNumbers(null);
                        break;
                    case 13:
                        ExerciseThirteen.ShowBiggestValue(null);
                        break;
                    case 14:
                        ExerciseFourteen.SortValues(null);
                        break;
                    case 15:
                        ExerciseFifteen.Show3And5multiples(null);
                        break;
                    case 16:
                        ExerciseSixteen.CalculateIncomeTax(null);
                        break;
                    case 17:
                        ExerciseSeventeen.PrintMultiplicationTable(null);
                        break;
                    case 18:
                        ExerciseEighteen.CalculatePriceOfApples(null);
                        break;
                    default:
                        break;
                }

                if (choice == 0) {
                    break;
                }
            }
        }
    }
}