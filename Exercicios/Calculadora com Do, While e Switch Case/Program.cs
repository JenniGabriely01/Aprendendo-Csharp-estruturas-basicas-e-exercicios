// Fazer uma calculadora com do/while
namespace Exercicio
{
    public class Ex1
    {
        public static void Main()
        {
            int opcao = 0;
            Console.WriteLine("Escolha um número:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um segundo número:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("=Bem-Vindo=");
                Console.WriteLine("Opção 1 - Somar:");
                Console.WriteLine("Opção 2 - Subtrair:");
                Console.WriteLine("Opção 3 - Multiplicação:");
                Console.WriteLine("Opção 4 - Divisão:");
                Console.WriteLine("Opção 5 - Sobra divisão:");
                Console.WriteLine("Opção 6 - Descobrir se os números são iguais:");
                Console.WriteLine("Opção 7 - Maior ou menor que o outro:");
                Console.WriteLine("Opção 8 - Sair");
                Console.WriteLine("Escolha uma opção");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int soma = n1 + n2;
                        Console.WriteLine(soma);
                        break;
                    case 2:
                        int subtracao = n1 - n2;
                        Console.WriteLine(subtracao);
                        break;
                    case 3:
                        int multip = n1 * n2;
                        Console.WriteLine(multip);
                        break;
                    case 4:
                        int div = n1 / n2;
                        Console.WriteLine(div);
                        break;
                    case 5:
                        int sobDiv = n1 % n2;
                        Console.WriteLine(sobDiv);
                        break;
                    case 6:
                        if (n1 == n2)
                        {
                            Console.WriteLine("Os números são iguais");
                        }
                        else
                        {
                            Console.WriteLine("Os número são diferentes");
                        }
                        break;
                    case 7:
                        if (n1 > n2)
                        {
                            Console.WriteLine($"o número {n1} é maior que o {n2}");
                        }
                        else if (n2 > n1)
                        {
                            Console.WriteLine($"o número {n2} é maior que o {n1}");
                        }
                        else
                        {
                            Console.WriteLine("Os números são iguais");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Saindo");
                        break;
                }
            } while (opcao != 8);
        }
    }
}