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
    public partial class Atualizar_cadastro : Form
    {
        DAO bd;
        public Atualizar_cadastro()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBoxCPF1_TextChanged(object sender, EventArgs e)
        {

        }//fim cpf

        private void textLogin2_TextChanged(object sender, EventArgs e)
        {

        }//fim do login

        private void textBoxSenha3_TextChanged(object sender, EventArgs e)
        {

        }//fim do senha

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long cpf = Convert.ToInt64(textBoxCPF1.Text);
                string login = textLogin2.Text;
                string senha = textBoxSenha3.Text;
                //Atualizar os dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", login, senha));
                //Limpar os campos
                textBoxCPF1.Text = "";
                textLogin2.Text = "";
                textBoxSenha3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//fim do botao atualizar

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botao cancelar
    }//fim do project 
}//fim da classe
