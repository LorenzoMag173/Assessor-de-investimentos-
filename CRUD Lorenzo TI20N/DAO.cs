using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace CRUD_Lorenzo_TI20N
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] cpf;
        public string[] login;
        public string[] senha;
        public int i;
        public int contador;

        public DAO() 
        {
            conexao = new MySqlConnection("server=localhost;Database=CBJinvestimentos;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }

        }//fim do construct


        public string Inserir(long cpf, string login, string senha)
        {
            string inserir = $"Insert into pessoa(cpf, nome, telefone, endereco) values" +
                $"('{cpf}','{login}','{senha}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }//fim do método

        public void PreencherVetor()
        {
            string query = "select * from cadastro";

            //Instanciar
            this.cpf = new long[100];
            this.login = new string[100];
            this.senha = new string[100];
           
            //Fazer o comando de seleção do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cpf[i] = Convert.ToInt64(leitura["cpf"]);
                login[i] = leitura["login"] + "";
                senha[i] = leitura["senha"] + "";
                i++;//Percorrer o vetor
                contador++;//Contar quantos dados eu tenho
            }//fim do while

            //Encerro a comunicação com o software
            leitura.Close();
        }//fim do preencher

        //Criar o método para retornar o contador
        public int QuantidadeDados()
        {
            return contador;
        }//fim do quantidade de dados

        public string Atualizar(long cpf, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado!";
            return resultado;
        }//fim do método

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluído!";
            return resultado;
        }//fim do excluir







    }//fim da class
}//fim do project
