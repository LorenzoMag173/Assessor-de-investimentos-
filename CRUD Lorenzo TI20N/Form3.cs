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
    public partial class Excluir1 : Form
    {
        DAO bd;
        public Excluir1()
        {
            InitializeComponent();
            bd = new DAO();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textboxExcluir_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo excluir

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(botaoExcluir.Text);//Coletando o CPF
                                                          //Chamar o método
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));
                //limpando o banco
                botaoExcluir.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//fim do botao excluir

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botao cancelar
    }//fim da class 
}//fim do project
