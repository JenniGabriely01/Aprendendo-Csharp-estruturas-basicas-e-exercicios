namespace Aula17___Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {
                "Mango",
                "Banana",
                "Apple",
                "Grapes"
            };

            //acessar valores 
            Console.WriteLine(fruits[0]);

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // adicionar um valor
            fruits.Add("Pineapple");

            // remover um valor
            fruits.Remove("Banana");

            // contar quantos itens tem na lista
            Console.WriteLine(fruits.Count);

            // modificar um elemento 
            fruits[1] = "Strawberry";

            // limpar a lista
            fruits.Clear();

            // declarar sem inicializar
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(2);
            numbers.Add(50);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
    }
}
}
