namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("O número é par");
            } else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}