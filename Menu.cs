using System;

namespace exercicios {
    class Exercicios {
        static void Main (string[] args)
        {
            int choice = 0;

            while (true) {

                Console.WriteLine("\nEste projeto contém 18 Exercícios. \nDigite um número para ver a solução. \nDigite 0 para sair.\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:
                        ExerciseOne.One(null);
                        break;
                    case 2:
                        ExerciseTwo.Two(null);
                        break;
                    case 3:
                        ExerciseThree.Three(null);
                        break;
                    case 4:
                        ExerciseFour.Four(null);
                        break;
                    case 5:
                        ExerciseFive.Five(null);
                        break;
                    case 6:
                        ExerciseSix.Six(null);
                        break;
                    case 7:
                        ExerciseSeven.Seven(null);
                        break;
                    case 8:
                        ExerciseEight.Eight(null);
                        break;
                    case 9:
                        ExerciseNine.Nine(null);
                        break;
                    case 10:
                        ExerciseTen.Ten(null);
                        break;
                    case 11:
                        ExerciseEleven.Eleven(null);
                        break;
                    case 12:
                        ExerciseTwelve.Twelve(null);
                        break;
                    case 13:
                        ExerciseThirteen.Thirteen(null);
                        break;
                    case 14:
                        ExerciseFourteen.Fourteen(null);
                        break;
                    case 15:
                        ExerciseFifteen.Fifteen(null);
                        break;
                    case 16:
                        ExerciseSixteen.Sixteen(null);
                        break;
                    case 17:
                        ExerciseSeventeen.Seventeen(null);
                        break;
                    case 18:
                        ExerciseEighteen.Eighteen(null);
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