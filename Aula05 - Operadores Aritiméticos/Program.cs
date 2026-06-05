namespace Aula05
{
    public class Program 
    {
        public static void Main()
        {
            int n1 = 10;
            int n2 = 30; 

            int soma = n1 + n2; // +, -, *, /, %
            Console.WriteLine($"A soma de {n1} e {n2} é: {soma}");

            Console.WriteLine("Dgite um numero: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dgite segundo numero: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n3 - n4);

        }
    }
}
