using System;
using System.Collections.Generic;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> pedido = new List<string>();
            do
            {
                Console.WriteLine("1 - Batata, 5 reais");
                Console.WriteLine("2 - sanduiche, 2 reais");
                Console.WriteLine("3. Sundae.........2 reais");
                Console.WriteLine("4. milkshek.........2 reais");
                Console.WriteLine("5. Sair");
                Console.WriteLine("6. Finalizar pedido");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        pedido.Add("Batata");
                        Console.WriteLine("Batata adicionada!");
                        break;
                    case 2:
                        pedido.Add("Sanduíche");
                        Console.WriteLine("Sanduíche adicionado!");
                        break;
                    case 3:
                        pedido.Add("Sundae");
                        Console.WriteLine("Sundae adicionado!");
                        break;
                    case 4:
                        pedido.Add("Milkshake");
                        Console.WriteLine("Milkshake adicionado!");
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        return;
                    case 6:
                        Console.WriteLine("\n--- Resumo do Pedido ---");
                        if (pedido.Count > 0)
                        {
                            foreach (string item in pedido)
                            {
                                Console.WriteLine("- " + item);
                            }
                            Console.WriteLine("Total de itens: " + pedido.Count);
                        }
                        else
                        {
                            Console.WriteLine("Seu pedido está vazio.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                   
                }
                Console.WriteLine(escolha);
            } while (true);

        }
           
    }
}
 