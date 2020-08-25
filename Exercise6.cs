using System;
using System.Collections.Generic;
using System.Linq;

namespace ProwayExercises
{
    class ExerciseSix
    {
        static string candidateA = "";
        static string candidateB = "";

        static List<int> votes = new List<int>();

        public static void ElectronicBallotBox(string[] args)
        {
            while (true) {

                Console.WriteLine("\nExercício 6");
                Console.WriteLine(String.Join(
                    Environment.NewLine,
                    "Criar um algoritmo que simule uma urna eletrônica. ",
                    "Esta urna deve possuir dois candidatos e possui três modos. ",
                    "O primeiro é o modo de CADASTRO, onde o sistema pergunta o nome de cada um ",
                    "dos dois candidatos. Por medidas de segurança, para poder cadastrar um candidato ", 
                    "na urna o sistema deve solicitar ao usuário a senha para poder ter acesso ",
                    "(a senha do sistema é Pa$$w0rd). ",
                    "O segundo modo é o modo de VOTOS, onde o usuário informa 1 para votar ",
                    "no primeiro candidato e 2 para votar no segundo candidato. ",
                    "O terceiro modo, é o modo de APURAÇÃO DE VOTOS, ",
                    "onde o sistema verifica qual candidato tem mais votos. Caso o número de ",
                    "votos seja igual, o sistema deve imprimir a mensagem \"SEGUNDO TURNO\", ",
                    "caso contrário deve imprimir o nome do candidato vencedor ",
                    "e o número de votos que ele obteve. \n\n",
                    "ESCOLHA ENTRE AS OPÇÕES A SEGUIR DIGITANDO O NÚMERO DA OPÇÃO: ",
                    "CADASTRAR CANDIDATO 1",
                    "VOTAÇÃO 2",
                    "APURAÇÃO 3",
                    "SAIR 0"
                    ));

                string m = Console.ReadLine();
                int menu = Convert.ToInt32(m);

                switch (menu){
                    case 1: // CADASTRO
                        CreateCandidate();
                        break;
                    case 2: // VOTAÇÃO
                        Voting();
                        break;
                    case 3: // APURAÇÃO
                        ShowResults();
                        break;
                    default:
                        break;
                }

                if (menu == 0) break;
            }
        }
        static void CreateCandidate(){
            string password = "Pa$$w0rd";

            for (int i = 0; i < 2; i++){
                Console.WriteLine("Para cadastrar informe sua senha: ");
                password = Console.ReadLine();
                if (password == "Pa$$w0rd"){
                    Console.WriteLine("Informe o nome do primeiro candidato");
                    candidateA = Console.ReadLine();
                    Console.WriteLine("Informe o nome do segundo candidato");
                    candidateB = Console.ReadLine();
                    break;
                }
                else Console.WriteLine($"Senha incorreta. Você tem mais {3 - i} tentativa(s).");
            }
        }
        static void Voting(){
            while (true) {
                Console.WriteLine(String.Join(
                    Environment.NewLine,
                    $"Para votar no candidato {candidateA} digite 1",
                    $"Para votar no candidato {candidateB} digite 2",
                    $"Digite 0 para sair"
                ));
                int vote = Convert.ToInt32(Console.ReadLine());
                if (vote == 0) break;
                else votes.Add(vote);
            }
        }
        
        static void ShowResults(){

            Console.WriteLine($"Total de votos: {votes.Count}");

            var totalVotesA = (from vote in votes
                where vote == 1
                orderby vote
                select vote).Count();

            var totalVotesB = (from vote in votes
                where vote == 2
                orderby vote
                select vote).Count();

            if (totalVotesA == totalVotesB){
                Console.WriteLine("SEGUNDO TURNO");
            }
            else if (totalVotesA > totalVotesB){
                Console.WriteLine($"O candidato {candidateA} fez mais votos, totalizando {totalVotesA} votos. \n");
            }
            else Console.WriteLine($"O candidato {candidateB} fez mais votos, totalizando {totalVotesB} votos. \n");
            
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
    }
}