namespace Aula03; 

public class Program
{
    public static void Main()
    {
        // O number é possivel ser reatribuido, o que vai valer vai ser o ultimo 
        int number = 30;
        number = 20;
        Console.WriteLine("O valor da var é: " + number); // Imprime o 20, pois a ultima atribuição é a que prevalece
        number = 10;
        Console.WriteLine("O valor da var é: " + number); // Imprime o 10, pois a última atribuição é a que prevalece

        // Constante é um valor que não muda, não é possivel ser reatriuida 
        const int number2 = 30; 
        Console.WriteLine("O valor da constante é:" + number2);

        var variable = 30; // O tipo da variável é atribuido automaticamente 

        // O dynamic é um tipo que pode ser reatribuido para qualquer tipo, o que vai valer é o ultimo tipo atribuido
        dynamic test = 20;
        test = "Agora é uma string";

    }
}
