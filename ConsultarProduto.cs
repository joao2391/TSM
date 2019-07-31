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
    public partial class ConsultarProduto : Form
    {

        String status;

        public void limpar()
        {

            txtbNomeProd.Text = "";
            txtbValorProd.Text = "";
            txtbMarcaProd.Text = "";
            txtbDescriProd.Text = "";
            txtbPesqProd.Text = "";


        }


        public void carregaVars()
        {

            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }


            try
            {


                Conexao.Conectar();

                lstvwConProd.Items.Clear();


                if(txtbPesqProd.Text == ""){

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM produto ORDER BY nomeProduto ASC";


                }
                else
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM produto WHERE nomeProduto LIKE '%" + txtbPesqProd.Text + "%' ORDER BY nomeProduto ASC";
                }

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while (Conexao.reader.Read())
                {


                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());


                    list.SubItems.Add(Conexao.reader[1].ToString());
                    list.SubItems.Add(Conexao.reader[2].ToString());
                    list.SubItems.Add(Conexao.reader[3].ToString());
                    list.SubItems.Add(Conexao.reader[4].ToString());


                    lstvwConProd.Items.AddRange(new ListViewItem[] { list });



                }

                Conexao.conMySQL.Close();
                Conexao.reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }




        public ConsultarProduto()
        {
            InitializeComponent();
        }

        private void lstvwConProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                Conexao.Conectar();

                txtbNomeProd.Text = lstvwConProd.Items[lstvwConProd.FocusedItem.Index].SubItems[1].Text;
                txtbValorProd.Text = lstvwConProd.Items[lstvwConProd.FocusedItem.Index].SubItems[2].Text;
                txtbMarcaProd.Text = lstvwConProd.Items[lstvwConProd.FocusedItem.Index].SubItems[3].Text;
                txtbDescriProd.Text = lstvwConProd.Items[lstvwConProd.FocusedItem.Index].SubItems[4].Text;
                


            }
            catch (Exception)
            {
                MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Conexao.conMySQL.Close();
            Conexao.reader.Close();


        }

        private void ConsultarProduto_Load(object sender, EventArgs e)
        {


            try
            {

                carregaVars();

                status = "novo";



            }
            catch (Exception)
            {
                MessageBox.Show(" ERRO! ");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

           
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }

            try
            {

                Conexao.Conectar();

            

            Conexao.cmdMySQL.CommandText = "UPDATE produto SET nomeProduto = '" + txtbNomeProd.Text + "',valorProduto='" + txtbValorProd.Text + "',marcaProduto = '" + txtbMarcaProd.Text + "',descricaoProduto='" + txtbDescriProd.Text + "'WHERE idProduto = '" + lstvwConProd.Items[lstvwConProd.FocusedItem.Index].Text + "'";
            Conexao.cmdMySQL.ExecuteNonQuery();

            MessageBox.Show("Produto Atualizado com Sucesso.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaVars();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            Conexao.conMySQL.Close();
            

        }

        private void txtbPesqProd_TextChanged(object sender, EventArgs e)
        {

            carregaVars();
        }

        private void btnExcluirCProd_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Deseja excluir esse produto?","Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    Conexao.Conectar();

                    Conexao.cmdMySQL.CommandText = "DELETE FROM produto WHERE idProduto='" + lstvwConProd.Items[lstvwConProd.FocusedItem.Index].Text + "'";

                    Conexao.cmdMySQL.ExecuteNonQuery();

                    MessageBox.Show("Produto deletado com sucesso.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    carregaVars();

                    limpar();

                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

                Conexao.conMySQL.Close();


            }




        }

        private void btnLimpCProd_Click(object sender, EventArgs e)
        {


            txtbNomeProd.Text = "";
            txtbValorProd.Text = "";
            txtbMarcaProd.Text = "";
            txtbDescriProd.Text = "";
            txtbPesqProd.Text = "";
            


        }
    }
}
