using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_Prof_Andre
{
    public class Banco
    {
        readonly string conexao = "Data Source=localhost;Initial Catalog=NomeDoBD;User id=sa;Password=SqlServer2019!";

        public Banco() { } //Construtor vazio

        public string Caminho() { return conexao; } //Metodo para retornar o caminho da conexao ao banco de dados SQLServer
    }
}
