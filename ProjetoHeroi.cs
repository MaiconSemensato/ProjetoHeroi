using System;
public class ProjetoHeroi {
    public static void main(String[] args) {
        string nome;
        int xp;
        int op;

        while (true) {
            Console.WriteLine("Escolha um Herói:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Paladino");
            Console.WriteLine("4 - SemiDeus");
            Console.WriteLine("5 - Deus");
            Console.WriteLine("6 - AnjoGuaradião");
            Console.WriteLine("7 - Humano");
            Console.WriteLine("8 - Caçador");
            op =  Convert.ToInt32(Console.ReadLine());
        }
    }
}