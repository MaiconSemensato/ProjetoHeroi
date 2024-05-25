using System;

namespace ProjetoHeroi
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            string nome = "";
            string nivel = "";
            int xp = 0;
            int op;
            bool sair = true;

            while (sair)
            {
                Console.WriteLine("Escolha um Herói:");
                Console.WriteLine("1 - Guerreiro");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Paladino");
                Console.WriteLine("4 - SemiDeus");
                Console.WriteLine("5 - Deus");
                Console.WriteLine("6 - AnjoGuaradião");
                Console.WriteLine("7 - Humano");
                Console.WriteLine("8 - Caçador");
                Console.WriteLine("0 - Para sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        sair = false;
                        break;
                    case 1:
                        nome = "Guerreiro";
                        nivel = "Ferro";
                        xp = 900;
                        break;
                    case 2:
                        nome = "Mago";
                        nivel = "Bronze";
                        xp = 1300;
                        break;
                    case 3:
                        nome = "Paladino";
                        nivel = "Prata";
                        xp = 2400;
                        break;
                    case 4:
                        nome = "SemiDeus";
                        nivel = "Ouro";
                        xp = 5500;
                        break;
                    case 5:
                        nome = "Deus";
                        nivel = "Platina";
                        xp = 7400;
                        break;
                    case 6:
                        nome = "AnjoGuaradião";
                        nivel = "Ascendente";
                        xp = 8600;
                        break;
                    case 7:
                        nome = "Humano";
                        nivel = "Imortal";
                        xp = 9500;
                        break;
                    case 8:
                        nome = "Caçador";
                        nivel = "Radiante";
                        xp = 10800;
                        break;
                    default:
                        Console.WriteLine("Codigo inválido");
                        break;
                }
                if (op > 0 && op < 9)
                {
                    Console.WriteLine(string.Format("O Herói de nome {0} está no nível de {1} com XP {2}", nome, nivel, xp));
                }
            }
        }
            
        
    }
}

