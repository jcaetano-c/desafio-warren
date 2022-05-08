using System.Collections;

namespace DesafioWarrenTechAcademy
{
    public class Desafio3
    {
        public void Desafio()
        {
            Console.Write("Informe a soma alvo: ");
            int soma = int.Parse(Console.ReadLine());

            int valor = 0;
            List<int> nums = new List<int>();

            Console.WriteLine($"Digite uma sequência de números inteiros: ");
            Console.WriteLine("-1 para sair");
            for (int i = 0; valor != -1; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor != -1)
                    nums.Add(valor);
            }
            encontrarCombinacao(nums, soma);
        }
            
            private void encontrarCombinacao(List<int> nums, int soma)
        {
            Hashtable set = new Hashtable();
            bool encontrado = false;

            for (int i = 0; i < nums.Count; i++)
            {
                if(set.Contains(soma - nums[i]))
                {
                    encontrado = true;
                    Console.WriteLine($"{{ {soma - nums[i]}, {nums[i]} }}");
                }

                set.Add(nums[i], i);
            }

            if (!encontrado)
                Console.WriteLine("Par não encontrado.");
        
        }
    }
}