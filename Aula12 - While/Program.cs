namespace Aula12___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            // Enquanto
            //while (i <= 5)
            //{
            //    Console.WriteLine("Loop infinito " + i);
            //    i++;
            //}

            // Ex2
            double budget = 1000;

            while(budget >0) 
            {
                Console.WriteLine(budget);
                budget--;
            }
        }
    }
}
