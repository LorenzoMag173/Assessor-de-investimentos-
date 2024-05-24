using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Lorenzo_TI20N
{
    public partial class CBJ : Form
    {
        DAO bd;
        Pagina_inicial pg;
        Atualizar_cadastro cd;
        Cadastrar ca;
        Excluir1 ex;

        public CBJ()
        {
            InitializeComponent();
            bd = new DAO();
            pg = new Pagina_inicial();
            cd = new Atualizar_cadastro();
            ca = new Cadastrar();
            ex = new Excluir1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            
        }//fim do login

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("    Tem certeza que deseja Sair?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }

        }//fim do botao fechar 

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            pg.ShowDialog();
        }

        private void atualizarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ca.ShowDialog();
        }
    }//fim do project
}//fim da classe 
