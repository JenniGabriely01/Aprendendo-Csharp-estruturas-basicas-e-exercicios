namespace Aula16___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Obtendo 1 valor específico
            Console.WriteLine(fruits[0]); // Output: Apple

            // Listando todos os valores
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Contagem de indices 
            Console.WriteLine("Quantidade de frutas: " + fruits.Length);

            // ALterar valores
            Console.WriteLine("Fruta original: " + fruits[0]); // Output: Apple
            fruits[0] = "Apricot";
            Console.WriteLine("Fruta alterada: " + fruits[0]); // Output: Apricot

            // Declarar sem inicializar
            int[] nums = new int[5];
            nums[0] = 10;
            nums[1] = 20;
            nums[3] = 30;
            nums[4] = 40;
            nums[5] = 50;

            foreach (int num in nums)
            {
                Console.WriteLine(num);  
            }
        }
    }
}
