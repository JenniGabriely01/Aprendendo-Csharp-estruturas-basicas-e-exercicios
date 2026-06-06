namespace Aula14___For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de repetição for, onde é possível definir uma variável de controle, uma condição de parada e um incremento/decremento.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"O valor de 7 x {i} é: {7 * i}");
            }

           
        }
    }
}
