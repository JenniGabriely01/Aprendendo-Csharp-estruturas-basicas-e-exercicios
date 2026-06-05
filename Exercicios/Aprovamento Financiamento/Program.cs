namespace Exercicio
{
    public class Ex2
    {
        public static void Main()
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu salario bruto: ");
            int income = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do veiculo: ");
            int car = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu valor de entrada: ");
            int entrada = Convert.ToInt32(Console.ReadLine());

            double valorFin = car - entrada;
            double valorParcela = valorFin / 48;

            if (age < 18)
            {
                Console.WriteLine("Menor de idade, reprovado");
                return;
            }
            else if (entrada < car * 0.20)
            {
                Console.WriteLine("Entrada menos que 20% do valor, reprovado");
                return;
            }
            else if (valorParcela > income * 0.30)
            {
                Console.WriteLine("Valor da parcela maior que 30% do salário, reprovado");
                return;
            }
            else
            {
                Console.WriteLine("Aprovado");

            }
        }

    }

}