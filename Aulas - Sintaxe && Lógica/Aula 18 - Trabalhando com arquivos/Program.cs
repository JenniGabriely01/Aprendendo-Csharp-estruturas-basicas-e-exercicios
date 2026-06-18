namespace Aula_18___Trabalhando_com_arquivos;
using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("file.txt", "Hello World");
            Console.WriteLine("Arquivo criado com sucesso");

            // Criar o arquivo em um local especifico 
            string path = @"C:\\Users\\ASUS\\source\\repos\\Aulas\\Aula 18 - Trabalhando com arquivos/fileName.txt";
            string content = "Hello World";
            File.WriteAllText(path, content);
            Console.WriteLine("Arquivo criado com sucesso");

            // Criar um arquivo word
            string path1 = @"C:\\Users\\ASUS\\source\\repos\\Aulas\\Aula 18 - Trabalhando com arquivos/";
            string fileName = "fileNameWord.doc";
            string filePath = path1 + fileName;

            string content1 = "Hello World";
            File.WriteAllText(filePath, content1);
            Console.WriteLine("Arquivo criado com sucesso");

            // Inserir um paragrafo em um arquivo 
            string path2 = @"C:\\Users\\ASUS\\source\\repos\\Aulas\\Aula 18 - Trabalhando com arquivos/";
            string fileName1 = "fileNameWord.doc";
            string filePath1 = path2 + fileName1;

            string addContent = "Curso de .NET";
            File.AppendAllText(filePath1, addContent);
            Console.WriteLine("Arquivo atualizado com sucesso");

            //Ler o arquivo
            string fileContent = File.ReadAllText(filePath1);
            Console.WriteLine("Conteudo do arquivo" + fileContent);
    }
}

