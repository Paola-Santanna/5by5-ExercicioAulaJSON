using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proj2_Prof_Andre
{
    public class TestFilters
    {
        public TestFilters() { }

        public static void CleanPrompt() 
        {
            Console.WriteLine("\nPressione ENTER...");
            Console.ReadKey();
            Console.Clear();
        } 
        public static int GetCountRecords( List<PenalidadesAplicadas> list) => list.Count();

        public static string PrintData(List<PenalidadesAplicadas> l)
        {
            foreach (var item in l)
                Console.WriteLine(item.ToString() + "\n");
            return null;
        }

        public static List<PenalidadesAplicadas> FilterByCPF(List<PenalidadesAplicadas> listaPenalidades) => listaPenalidades.Where(pessoa => pessoa.cpf.Substring(0,3) == "237").ToList();

        public static List<PenalidadesAplicadas> FilterByVigencia(List<PenalidadesAplicadas> listaViencia) => listaViencia.Where(pessoa => pessoa.vigencia_do_cadastro.Substring(6,4) == "2021").ToList();

        public static List<PenalidadesAplicadas> FilterByRazaoSocial(List<PenalidadesAplicadas> listaRazaoSocial) => listaRazaoSocial.Where(pessoa => pessoa.razaoSocial.Contains("LTDA")).ToList();

        public static List<PenalidadesAplicadas> OrderByRazaoSocial(List<PenalidadesAplicadas> listaOrdenarRazaoSocial) => listaOrdenarRazaoSocial.OrderBy(pessoa => pessoa.razaoSocial).ToList();
        public static string GenerateXML(List<PenalidadesAplicadas> listaXML)
        {
            if (listaXML.Count > 0)
            {
                var penalidadeAplicada = new XElement("Root", from data in listaXML
                                                              select new XElement("motorista",
                                                              new XElement("razao_social", data.razaoSocial),
                                                              new XElement("cnpj", data.cnpj),
                                                              new XElement("nome_motorista", data.nome_motorista),
                                                              new XElement("cpf", data.cpf),
                                                              new XElement("vigencia_do_cadastro", data.vigencia_do_cadastro)
                                                              )
                                                            );
                //where data.cpf = "numero do cpf"
                return penalidadeAplicada.ToString();
            }
            else
            {
                return "Não existem registros";
            }
        }


    }
}
