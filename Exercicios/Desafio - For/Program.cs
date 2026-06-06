namespace Desafio___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // desafio - taboada
            Console.WriteLine("Digite um número para calcular a tabuada:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"O valor de {num} x {i} é: {num * i}");
            }

            // desafio 2
            // CONSTRUA UM ALGORITIMO ONDE O USUÁRIO VAI INFOMAR UM NUMERO ENTRE 1 E 100, E O SISTEMA DEVE MOSTRAR TODOS OS NÚMEROS SEQUENCIAIS DE 0 ATÉ O NÚMERO INFORMADO.

            Console.WriteLine("Digite o numero final:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine($"o valor de {i} + {num2} é: {i + num2}");
            }

            // desafio 3 
            // 2) CONSTRUA UM ALGORITIMO ONDE O USUÁRIO VAI INFORMAR O NÚMERO FINAL E O MULTIPLICADOR E O SISTEMA DEVE MOSTRAR DE 0 ATÉ O NÚMERO FINAL E SOMANDO O MULTIPLICADOR
            Console.WriteLine("Digite o numero final:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o multiplicador:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<=num3; i = i + num4)
            {
                Console.WriteLine($"o valor de {i} + {num4} é: {i + num4}");
            }
        }
    }
}
