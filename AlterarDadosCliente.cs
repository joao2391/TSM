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
    public partial class AlterarDadosCliente : Form
    {

        String status;

        public void limpar()
        {

            txtbAltNome.Text = "";
            txtbAltRG.Text = "";
            txtbAltEnd.Text = "";
            txtbAltEmail.Text = "";
            txtbAltTel.Text = "";
            txtbAltDtNasc.Text = "";
            txtbInfo.Text = "";


        }

        public void carregaVars()
        {


            //ELIMINAR FK DO AGENDAMENTO E FK DA TABELA INFORMAÇOES DA TABELA CLIENTE!

            // ELIMINAR TABELA ESTOQUE E FK DO ESTOQUE DA TABELA PRODUTO!

            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }
            

            try
            {

                Conexao.Conectar();

                lstvwAlterar.Items.Clear();


                if (txtbPesquisa.Text == "")
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM cliente ORDER BY nomeCliente ASC";

                }
                else
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM cliente WHERE nomeCliente LIKE '%" + txtbPesquisa.Text + "%' ORDER BY nomeCliente ASC";
                }

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while (Conexao.reader.Read())
                {
                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());

                    list.SubItems.Add(Conexao.reader[2].ToString());
                    list.SubItems.Add(Conexao.reader[7].ToString());
                    list.SubItems.Add(Conexao.reader[3].ToString());
                    list.SubItems.Add(Conexao.reader[5].ToString());
                    list.SubItems.Add(Conexao.reader[6].ToString());
                    list.SubItems.Add(Conexao.reader[4].ToString());
                    list.SubItems.Add(Conexao.reader[8].ToString());
                   

                    lstvwAlterar.Items.AddRange(new ListViewItem[] { list });
                }

                Conexao.reader.Close();
                Conexao.cmdMySQL.Dispose();
                Conexao.conMySQL.Close();
               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }


        public AlterarDadosCliente()
        {
            InitializeComponent();
        }

        private void btnCancelAlt_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void lstvwAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                Conexao.Conectar();

                txtbAltNome.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[1].Text;
                txtbAltRG.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[2].Text;
                //txtbAltCPF.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[3].Text;
                txtbAltEnd.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[3].Text;
                txtbAltTel.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[4].Text;
                txtbAltEmail.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[5].Text;
                txtbAltDtNasc.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[6].Text;
                txtbInfo.Text = lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].SubItems[7].Text;


            }


            catch (Exception)
            {
                MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Conexao.conMySQL.Close();
            Conexao.reader.Close();


        }

        private void btnSalvAlt_Click(object sender, EventArgs e)
        {

            Conexao.Conectar();

            try
            {
                               
            
            Conexao.cmdMySQL.CommandText = "UPDATE cliente SET nomeCliente = '" + txtbAltNome.Text + "',rgCliente='" + txtbAltRG.Text + "',Endereco = '" + txtbAltEnd.Text + "',DataNasc='" + txtbAltDtNasc.Text + "',Telefone='" + txtbAltTel.Text + "',emailCliente='" + txtbAltEmail.Text + "',observacao='" + txtbInfo.Text + "'WHERE idCliente = '" + lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].Text + "'";
            Conexao.cmdMySQL.ExecuteNonQuery();

            MessageBox.Show("Registro Atualizado com Sucesso.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaVars();
            
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

                //Conexao.reader.Close();
                Conexao.conMySQL.Close();
                Conexao.cmdMySQL.Dispose();
                

        }

        private void AlterarDadosCliente_Load(object sender, EventArgs e)
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

        private void txtbPesquisa_TextChanged(object sender, EventArgs e)
        {


            carregaVars();

        }

        private void btnDelCli_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Deseja excluir esse cliente?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    Conexao.Conectar();

                    Conexao.cmdMySQL.CommandText = "DELETE FROM cliente WHERE idCliente='" + lstvwAlterar.Items[lstvwAlterar.FocusedItem.Index].Text + "'";

                    Conexao.cmdMySQL.ExecuteNonQuery();

                    MessageBox.Show("Cliente deletado com sucesso.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    carregaVars();

                    limpar();
                                       
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

                //Conexao.reader.Close();
                Conexao.conMySQL.Close();
            }

            

        }

    }

}
