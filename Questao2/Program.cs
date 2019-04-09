using System;
using System.IO;
using System.Text.RegularExpressions;

namespace QuestaoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diretorios = Directory.GetFiles("C:\\Users\\User\\source\\repos\\QuestaoUm\\Questao2\\Arquivos");            
            
            foreach (string dir in diretorios)
            {
                string[] lines = System.IO.File.ReadAllLines(dir);
                foreach (var item in lines)
                {
                    FileInfo infoArquivo = new FileInfo(dir);
                    bool existeTelefone = Regex.IsMatch(@"^\([1 - 9]{ 2}\) (?:[2 - 8] | 9[1 - 9])[0 - 9]{ 3}\-[0 - 9]{ 4}$", item);
                    if (existeTelefone)
                    {
                        Console.WriteLine("Contém número de telefone");
                        Console.WriteLine("Nome: {0}", infoArquivo.Name);
                        Console.WriteLine("");
                        break;
                    }                    
                }
            }
            Console.ReadKey();
        }
    }
}
