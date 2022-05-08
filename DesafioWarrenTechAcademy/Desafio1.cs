namespace DesafioWarrenTechAcademy
{
    public class Desafio1
    {
        public void Desafio()
        {
            int num = 0;
            int reverso;
            int soma;

            do
            {
                soma = 0;
                reverso = Reverso(num);
                soma = num + reverso;
                if (soma % 2 == 1 && reverso > 10)
                    Console.WriteLine(num + reverso);
                num++;
            } while (soma < 1000000);
            Console.Write("Pressione ENTER para voltar ao menu...");
            Console.ReadKey();
        }

        private int Reverso(int num)
        {
            int reverso = 0;
            double i = 0;

            while(num > 0)
            {
                reverso = num % 10 + (int)(reverso * Math.Pow(10.0, i));
                num /= 10;
                i++;
            }

            return reverso;
        }
    }
}