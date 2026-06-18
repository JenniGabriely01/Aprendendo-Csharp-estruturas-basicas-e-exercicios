namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    double soma = n1 + n2;
                    Console.WriteLine("O resultado é " + soma);
                    break;
                case "-":
                    double sub = n1 - n2;
                    Console.WriteLine("O resultado é " + sub);
                    break;
                case "/":
                    double div = n1 / n2;
                    Console.WriteLine("O resultado é " + div);
                    break;
            }
        }
    }
}
