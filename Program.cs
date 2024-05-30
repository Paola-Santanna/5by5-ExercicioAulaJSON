//Aprender a ler arquivos JSON

using Proj2_Prof_Andre;
using System.Xml;

namespace Proj2_Prof_Andre
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>Aprendendo a Ler Arquivos JSON<<<".ToUpper());

            var list = ReadFile.GetData();
            bool sair = false;
            int opcao;

            /*
             * Esse trecho mostra o total de linhas que existem no arquivo "motoristas_habilitados.json"
             * foreach (var item in list)
             *      Console.WriteLine(item);
             * Console.WriteLine("\nTotal de Linhas: " + list.Count);
            */

            int Menu()
            {
                Console.WriteLine(">>>MENU<<<");
                Console.WriteLine("1 -> Listar todos os arquivos");
                Console.WriteLine("2 -> Mostrar a quantidade de linhas");
                Console.WriteLine("3 -> Listar registros que tenham o número do documento (CPF) iniciando com 237");
                Console.WriteLine("4 -> Listar registros que tem o ano de vigência igual a 2021");
                Console.WriteLine("5 -> Mostrar as empresas em nome da razão social a descrição LTDA");
                Console.WriteLine("6 -> Mostrar a lista ordenada de registro, a partir da razão social");
                Console.WriteLine("7 -> Inserir todos os registros no SQLServer");
                Console.WriteLine("8 -> Gerar XML");
                Console.WriteLine("\n0 -> Sair");
                Console.Write("\nOpcao escolhida: ");
                int opcao = int.Parse(Console.ReadLine());
                return opcao;
            }

            do
            {
                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nSaindo...");
                        sair = true;
                        TestFilters.CleanPrompt();
                        break;

                    case 1:
                        Console.WriteLine($"Todos os Arquivos: \n\n");
                        TestFilters.PrintData(list);
                        TestFilters.CleanPrompt();
                        break;

                    case 2:
                        Console.WriteLine($"Quantidade de linhas: {TestFilters.GetCountRecords(list)}");
                        TestFilters.CleanPrompt();
                        break;

                    case 3:
                        Console.WriteLine("Listar registros que tenham o número do documento (CPF) iniciando com 237:\n\n");
                        TestFilters.PrintData(TestFilters.FilterByCPF(list));
                        TestFilters.CleanPrompt();
                        break;

                    case 4:
                        Console.WriteLine("Listar registros que tem o ano de vigência igual a 2021:\n\n");
                        TestFilters.PrintData(TestFilters.FilterByVigencia(list));
                        TestFilters.CleanPrompt();
                        break;

                    case 5:
                        Console.WriteLine("Quantas empresas em nome da razão social a descrição LTDA");
                        TestFilters.PrintData(TestFilters.FilterByRazaoSocial(list));
                        Console.WriteLine("\n\nQuantidade de empresas LTDA: " + TestFilters.FilterByRazaoSocial(list).Count());
                        TestFilters.CleanPrompt();
                        break;

                    case 6:
                        Console.WriteLine("Ordenar a lista de registro pela razão social");
                        TestFilters.PrintData(TestFilters.OrderByRazaoSocial(list));
                        TestFilters.CleanPrompt();
                        break;

                    case 7:
                        Console.WriteLine("Inserir todos os registros no SQLServer");
                        TestFilters.CleanPrompt();
                        break;

                    case 8:
                        Console.WriteLine("Gerar XML");
                        Console.WriteLine(TestFilters.GenerateXML(list));
                        TestFilters.CleanPrompt();
                        break;

                    default:
                        Console.WriteLine("\nOpcao Invalida!\n");
                        TestFilters.CleanPrompt();
                        break;
                }

            } while (sair != true);
        }
    }
}