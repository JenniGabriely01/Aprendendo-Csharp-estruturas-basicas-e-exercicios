namespace Exercicio_soma_e_multiplicação_com_input_e_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O usuario deve informar 2 numeros e exibir a soma entre eles, em seguida o usuário deve informar mais um número e o sistema deve multiplicar o resultado da soma pelo número informado e exibir o resultado final.

            Console.WriteLine("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"A soma dos números é: {soma}");

            Console.WriteLine("Digite um novo número pra multiplicar a soma: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O resultado final é {soma * n3}");
        }
    }
}
