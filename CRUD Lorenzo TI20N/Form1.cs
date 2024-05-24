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
        public CBJ()
        {
            InitializeComponent();
            bd = new DAO();
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
            if(Login_TextChanged.Text=="login" && Senha_TextChanged.Text=="1234")
            {
                MessageBox.Show("Bem vindo investidor");
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos!");
            }
        }//fim do login
    }//fim do project
}//fim da classe 
