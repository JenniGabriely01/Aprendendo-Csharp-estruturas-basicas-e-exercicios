namespace Aula04___Input_e_Output
{
    public class Program
    {
        public static void Main()
        {
            // Solicitar o nome do usuário
            Console.WriteLine("Digite o seu nome:");
            string name = Console.ReadLine(); // Só le string 

            //Solicitar a idade do usuário
            Console.WriteLine("Digite a sua idade:");
            int age = Convert.ToInt32(Console.ReadLine()); // Converte a string para inteiro

            Console.WriteLine($"Olá {name}, bem-vindo");
            Console.WriteLine($"Você tem {age} anos");
        }
    }
}
