namespace Média_Escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  receber 3 notas, calcular a média e mostrar se foi reprovado 
            Console.WriteLine("Digite a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
            if(media > 6)
            {
                Console.WriteLine("Aprovado");
            } else if (media > 3 && media < 6)
            {
                Console.WriteLine("Recuperação");
            } else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
