namespace Exercicio
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Financiamento");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Ex1.Executar();
                    break;

                case 2:
                    Ex2.Executar();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}