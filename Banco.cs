using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_Prof_Andre
{
    public class Banco
    {
        readonly string conexaoBD = "string de conexão";

        public Banco() { } //Construtor vazio

        public string Caminho() { return conexaoBD; } //Metodo para retornar o caminho da conexão ao banco de dados SQLServer
    }
}
