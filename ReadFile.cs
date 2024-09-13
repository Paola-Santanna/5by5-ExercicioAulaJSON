using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace Proj2_Prof_Andre
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData()
        {
            StreamReader r = new StreamReader("caminho do arquivo");
            string jsonString = r.ReadToEnd();

            //Processo de descerialização 
            var objetoGeral = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter{ DateTimeFormat = "dd/MM/yyyy" });

            if (objetoGeral != null) return objetoGeral.PenalidadesAplicadas;
           
            return null;
        }

        public override string? ToString()
        {
            return base.ToString();
        }


    }
}
