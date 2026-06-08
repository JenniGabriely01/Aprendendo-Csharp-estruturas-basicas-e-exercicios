namespace Exercicio___IF_e_Else_Saldo_Bancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritimo que deve pedir ao usuário o valor que ele quer sacar, seguida o sistema deve verificar se o valor é menor ou maior que o disponivel 
            // se sim, efetuar o saque e mostrar o novo valor disponivel
            // se não, informar que não tem saldo suficiente
            // Assumir que o cliente tem 1000 pra saque 

            Console.WriteLine("Quanto deseja sacar? ");
            double saque = Convert.ToDouble(Console.ReadLine());
            double saldo = 1000; 

            if(saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente para essa transferencia");
            } else
            {
                Console.WriteLine("Transferencia realizada com sucesso");
            }
        }
    }
}
