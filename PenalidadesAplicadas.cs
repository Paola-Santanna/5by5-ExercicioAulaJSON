using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_Prof_Andre
{
    public class PenalidadesAplicadas
    {
        /*
         * {
         *      "razao_social":"1A - GRANTURISMO TRANSPORTE LTDA ME",
         *      "cnpj":"03.865.605/0001-33",
         *      "nome_motorista":"ALEX  ************ ANTOS",
         *      "cpf":"670.***.***-20",
         *      "vigencia_do_cadastro":"02/12/2021"
         * }
         */

        [JsonProperty("razao_social")]
        public string razaoSocial { get; set; }

        [JsonProperty("cnpj")]
        public string cnpj { get; set; }

        [JsonProperty("nome_motorista")]
        public string nome_motorista { get; set; }

        [JsonProperty("cpf")]
        public string cpf { get; set; }

        [JsonProperty("vigencia_do_cadastro")]
        public string vigencia_do_cadastro { get; set; }

        public override string? ToString() => $"razao_social: {this.razaoSocial}, cnpj: {this.cnpj}, nome_motorista: {this.nome_motorista}, cpf: {this.cpf}, vigencia_do_cadastro: {this.vigencia_do_cadastro}";
    }
}
