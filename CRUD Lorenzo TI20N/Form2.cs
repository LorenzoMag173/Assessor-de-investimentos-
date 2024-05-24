using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Lorenzo_TI20N
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }//fim do construct

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo login 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo senha

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo CPF

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados do banco
                long cpf = Convert.ToInt64(textBox1.Text);
                string login = textBox2.Text;
                string senha = textBox3.Text;
              
                //Cadastrar
                MessageBox.Show(bd.Inserir(cpf, login, senha));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }

        }//fim botao cadastrar
    }//fim da classe 
}//fim do project
