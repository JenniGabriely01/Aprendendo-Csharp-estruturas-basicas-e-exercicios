namespace Aula10___Calc_Simples
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool varContinue = true;

            while (varContinue) 
            {
                Console.WriteLine("Calculadora simples");
                Console.WriteLine("Digite um número");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite um  segundo número");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                int oper = Convert.ToInt32(Console.ReadLine());

                double resultado = 0;

                if (oper == 1)
                {
                    resultado = num1 + num2;

                }
                else if (oper == 2)
                {
                    resultado = num1 - num2;
                }
                else if (oper == 4)
                {
                    resultado = num1 * num2;
                }
                else if (oper == 4)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero");
                    }
                }
                else
                {
                    Console.WriteLine("Operação inválida");
                }

                Console.WriteLine("O resultado é: " + resultado);

                Console.WriteLine("Deseja realizar outra operação? (s/n)");
                string respos = Console.ReadLine();
                if (respos == "s" || respos == "S")
                {
                    varContinue = true;
                } else
                {
                    varContinue = false;
                }
            }
            
        }
    }
}
