using System.Security.Permissions;

namespace Aula11___Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool boolValue = true;

            //switch(boolValue)
            //{
            //    case true: 
            //        Console.WriteLine("True");
            //        break;
            //    case false:
            //        Console.WriteLine("False");
            //        break;
            //}

            Console.WriteLine("Dia da semana");
            Console.WriteLine("Digite um numero de 1 a 7");
            int diaSemana = Convert.ToInt32(Console.ReadLine()); 

            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2: 
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

            // ex 3
            Console.WriteLine("==Desempenho Escolar==");
            Console.WriteLine("Digite a nota do aluno");
            double nota = Convert.ToDouble(Console.ReadLine());

            switch(nota)
            {
                case 10:
                case 9:
                    Console.WriteLine("Great");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Good");
                    break;
                case 6:
                Console.WriteLine("Regular");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("Bad");
                    break; 
                
            }

        }
    }
}
