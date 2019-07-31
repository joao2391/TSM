using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattoSystemManager
{
    public partial class CadastrarProduto : Form
    {

        public void limpar()
        {

            txtbNomeProd.Text = "";
            txtbValorProd.Text = "";
            txtbMarcaProd.Text = "";
            txtbDescriProd.Text = "";


        }

        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {


            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }

            try
            {


                Conexao.Conectar();
                
                if (txtbNomeProd.Text == "")
                {

                    MessageBox.Show("Informe o nome do produto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNomeProd.Focus();
                }

                else if (txtbValorProd.Text == "")
                {

                    MessageBox.Show("Informe o valor do produto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbValorProd.Focus();

                }

                else if (txtbMarcaProd.Text == "")
                {
                    MessageBox.Show("Informe a marca do produto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbMarcaProd.Focus();

                }

                else if(txtbDescriProd.Text == "")
                {

                    MessageBox.Show("Informe a descrição do produto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbDescriProd.Focus();
                    
                }


                //Conexao.Conectar();


                Conexao.cmdMySQL.CommandText = "INSERT INTO produto (nomeProduto ,valorProduto, marcaProduto, descricaoProduto) VALUES ('"
                               + txtbNomeProd.Text + "','"
                               + txtbValorProd.Text + "','"
                               + txtbMarcaProd.Text + "','"
                               + txtbDescriProd.Text + "')";


                Conexao.cmdMySQL.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado!", "Salvar", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);





            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }

            limpar();



        }

        private void btnCancelProd_Click(object sender, EventArgs e)
        {
                       
            this.Close();


        }
    }
}
