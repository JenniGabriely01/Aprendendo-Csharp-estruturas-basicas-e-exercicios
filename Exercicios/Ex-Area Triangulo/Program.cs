namespace Ex_Area_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira medida do primeiro triangulo (base): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda medida do primeiro triangulo (altura): ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a primeira medida do segundo triangulo (base): ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda medida do segundo triangulo (altura): ");
            int n5 = Convert.ToInt32(Console.ReadLine());

            int areaTrianguloX = n1 + n2 / 2;
            int areaTrianguloY = n4 + n5 / 2;

            if(areaTrianguloX > areaTrianguloY)
            {
                Console.WriteLine("O triangulo X tem a maior área");
            } else
            {
                Console.WriteLine("O triangulo Y tem a maior área");
            }

        }
    }
}
