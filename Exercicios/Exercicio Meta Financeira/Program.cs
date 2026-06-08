namespace Exercicio_Meta_Financeira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Você vai calcular quanto dinheiro o investidor terá ao final do período e depois comparar esse valor com um objetivo que ele definiu.
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua meta financeira ");
            double metaFinanceira = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor inicial que você tem pra investir: ");
            double valorInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Por quantos meses você quer investir?");
            int meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Taxa de juros mensal: ");
            double taxaJuros = double.Parse(Console.ReadLine());

            double rendimento= valorInicial * (taxaJuros / 100) * meses;
            double final = rendimento + valorInicial;

            if (final >= metaFinanceira)
            {
                Console.WriteLine($"Parabéns {name}! Você atingiu sua meta financeira. O valor final do seu investimento é: {final}");
            } else
            {
                Console.WriteLine($"Infelizmente, {name}, você não atingiu sua meta. O valor final do seu investimento é {final} faltou {metaFinanceira - final} para você chegar lá :(");
            }


        }
    }
}
