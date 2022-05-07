namespace DesafioWarrenTechAcademy
{
    public class Desafio2
    {
        public void Desafio()
        {
            Console.Write("Informe o número de alunos: ");
            int numeroDeAluno = int.Parse(Console.ReadLine());

            Console.Write("Informe o limite de atrasos: ");
            int limite = int.Parse(Console.ReadLine());

            int[] presencas = new int[numeroDeAluno];
            for (int i = 0; i < numeroDeAluno; i++)
            {
                Console.Write($"Informe a preseça do aluno {i}: ");
                int presenca = int.Parse(Console.ReadLine());
                presencas[i] = presenca;
            }
            
            var atrasados = presencas.Where(n => n > 0);

            if (atrasados.Count() > limite)
                Console.WriteLine("Aula cancelada");
            else
                Console.WriteLine("Aula normal");
            Console.Write("Pressione ENTER para voltar ao menu...");
            Console.ReadKey();
        }
    }
}