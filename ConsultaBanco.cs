using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_Prof_Andre
{
    internal class ConsultaBanco
    {
        public ConsultaBanco() { }

        public void InsercaoDados(string rSocial, string cnpjDado, string nMotorista, string cpfDado, string vCadastro, SqlConnection conexao) 
        {
            SqlCommand cmd = new();

            cmd.CommandText = "INSERT INTO MOTORISTA (razao_social, cnpj, nome_motorista, cpf, vigencia_do_cadastro) VALUES (@razao_social, @cnpj, @nome_motorista, @cpf, @vigencia_do_cadastro)";

            cmd.Connection = conexao;

            cmd.Parameters.AddWithValue("@razao_social", rSocial);
            cmd.Parameters.AddWithValue("@cnpj", cnpjDado);
            cmd.Parameters.AddWithValue("@nome_motorista", nMotorista);
            cmd.Parameters.AddWithValue("@cpf", cpfDado);
            cmd.Parameters.AddWithValue("@vigencia_do_cadastro", vCadastro);
            cmd.ExecuteNonQuery();
        }
    }
}
