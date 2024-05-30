//Aprendendo a ler arquivos JSON

using Proj2_Prof_Andre;
using System.Xml;

namespace Proj2_Prof_Andre
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine(">>>Aprendendo a Ler Arquivos JSON<<<".ToUpper() + "\n");

            do
            {
                opcao = Menu.ShowMenu();
                Menu.OptionChoosed(opcao);
            } while (opcao != 0);
        }
    }
}