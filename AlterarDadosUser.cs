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
    public partial class AlterarDadosUser : Form
    {

        String status;


        public void limpar()
        {

            txtbNivel.Text = "";
            txtbNome.Text = "";
            txtbLogin.Text = "";
            txtbSenha.Text = "";


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

                lstvwAltDadosUser.Items.Clear();


                if (txtbPesquisa.Text == "")
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM usuario ORDER BY nomeUsuario ASC ";
                    //"SELECT *FROM usuario ORDER BY nomeUsuario ASC";

                }
                else
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM usuario WHERE nomeUsuario LIKE '%" + txtbPesquisa.Text + "%' ORDER BY nomeUsuario ASC";
                }

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while (Conexao.reader.Read())
                {


                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());


                    list.SubItems.Add(Conexao.reader[1].ToString());
                    list.SubItems.Add(Conexao.reader[3].ToString());
                    list.SubItems.Add(Conexao.reader[4].ToString());
                    list.SubItems.Add(Conexao.reader[2].ToString());


                    lstvwAltDadosUser.Items.AddRange(new ListViewItem[] { list });



                }

                Conexao.conMySQL.Close();
                Conexao.reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }

        public AlterarDadosUser()
        {
            InitializeComponent();
        }

        private void lstvwAltDadosUser_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                Conexao.Conectar();

                txtbNivel.Text = lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].SubItems[1].Text;
                txtbNome.Text = lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].SubItems[2].Text;
                txtbLogin.Text = lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].SubItems[3].Text;
                txtbSenha.Text = lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].SubItems[4].Text;



            }
            catch (Exception)
            {
                MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Conexao.conMySQL.Close();
            Conexao.reader.Close();

        }

        private void AlterarDadosUser_Load(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }


            try
            {

                Conexao.Conectar();            

            Conexao.cmdMySQL.CommandText = "UPDATE usuario SET nomeUsuario = '" + txtbNome.Text + "',Nivel_idNivel='" + txtbNivel.Text + "',SenhaUsuario = '" + txtbSenha.Text + "',login='" + txtbLogin.Text + "'WHERE idUsuario = '" + lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].Text + "'";
            Conexao.cmdMySQL.ExecuteNonQuery();

            MessageBox.Show("Registro Atualizado com Sucesso.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaVars();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

             }








        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir esse usuário?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    Conexao.Conectar();

                    Conexao.cmdMySQL.CommandText = "DELETE FROM usuario WHERE idUsuario='" + lstvwAltDadosUser.Items[lstvwAltDadosUser.FocusedItem.Index].Text + "'";

                    Conexao.cmdMySQL.ExecuteNonQuery();

                    MessageBox.Show("Usuário deletado com sucesso.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
