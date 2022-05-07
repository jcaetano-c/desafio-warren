namespace DesafioWarrenTechAcademy
{
    public class Desafio3
    {
        public void Desafio()
        {
            int n = 10;
            int[] v = { 2, 4, 3 };

            Array.Sort(v);
            var res = v.Where(x => x == n);
            if (res.Count() >= 1)
            {
                Console.WriteLine(n);
                return;
            }

            //int i = 0;
            //int j = n - 1;

        }
    }
}