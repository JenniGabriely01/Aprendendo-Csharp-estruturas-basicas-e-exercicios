namespace Aula08; 

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite um segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Operador de Igualdade (==), está verificando se o é true ou false
        if(numero == numero2)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine("Os números são diferentes.");
        }

        // Operador de Diferença (!=)
        if(numero != numero2)
        {
            Console.WriteLine("Os números são diferentes.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }

        // Operador de Maior que (>)
        if (numero > numero2)
        {
            Console.WriteLine("O primeiro número é maior que o segundo.");
        }
        else
        {
            Console.WriteLine("O primeiro número não é maior que o segundo.");
        }

        // Operador de Menor que (<)
        if (numero < numero2)
        {
            Console.WriteLine("O primeiro número é menor que o segundo.");
        }
        else
        {
            Console.WriteLine("O primeiro número não é menor que o segundo.");
        }
        // Operador de Maior ou Igual a (>=)
    }
}
