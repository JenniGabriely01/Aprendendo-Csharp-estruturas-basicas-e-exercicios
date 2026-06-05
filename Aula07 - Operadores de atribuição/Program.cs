namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            int x = 10;
            Console.WriteLine($"O operador inicial da variavel é {x}");
            // Console.WriteLine("O operador inicial da variavel é: " + x); 

            //Operador de atribuição simples (=)
            x = 20;

            //Atribuição composta (incremento)
            x++; // x = x + 1
            Console.WriteLine(x);

            //Atribuição composta - Tonra o codigo menor
            x+=10; // x = x + 10
            Console.WriteLine(x);
            x -=15; // x = x - 15 
            Console.WriteLine(x);

        }
    }
}
