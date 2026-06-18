namespace Aula15___For_Each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listas
            List<int>numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // diferente do for que executa um bloco de codigo varias vezes, de acordo com uma condição, o foreach é usado p percorrer os itens de uma coleção e percorre cada item executando uma função para cada um deles.
            foreach (int number in numberList)
            {
                // foreach (para cada um number no numberList) faça x
                Console.WriteLine(number);
            }
        }
    }
}
