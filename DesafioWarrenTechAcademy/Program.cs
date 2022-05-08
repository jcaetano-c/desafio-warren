using System;

namespace DesafioWarrenTechAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("DESAFIOS DESENVOLVIDOS POR JAIRO CAETANO JUNIOR.");
            Console.WriteLine("Qual desafio deseja executar?");
            Console.WriteLine("Digite 0 para sair.\n");
            short option = short.Parse(Console.ReadLine());
            Console.Clear();
            switch (option)
            {
                case 1:
                    Desafio1 desafio1 = new Desafio1();
                    desafio1.Desafio();
                    Menu();
                    break;
                case 2:
                    Desafio2 desafio2 = new Desafio2();
                    desafio2.Desafio();
                    Menu();
                    break;
                case 3:
                    Desafio3 desafio3 = new Desafio3();
                    desafio3.Desafio();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Menu();
                    break;
            }
        }
    }
}
