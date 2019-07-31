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
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void btnNUOk_Click(object sender, EventArgs e)
        {


            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }

            try
            {
                Conexao.Conectar();
                if (txtbNUNome.Text == "")
                {
                    MessageBox.Show("Informe o Nome do usuário.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNUNome.Focus();
                }

                else if (txtbNULogin.Text == "")
                {
                    MessageBox.Show("Informe o Login do administrador.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNULogin.Focus();
                }
                else if (txtbNUSenha.Text == "")
                {
                    MessageBox.Show("Informe a senha", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNUSenha.Focus();
                }
                else if (txtbNUCSenha.Text == "")
                {
                    MessageBox.Show("Digite a Senha.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

               //else if (cbxNivel.Text == "")
                //{

                    //MessageBox.Show("Digite a confirmação da Senha.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //}
                
                //FAZ A VERIFICAÇÃO DA SENHA SE AS SENHAS DIGITADAS SÃO IGUAIS...

                if ((txtbNULogin.Text != "") && (txtbNUSenha.Text != "") && (txtbNUCSenha.Text != ""))
                {

                    if (txtbNUSenha.Text == txtbNUCSenha.Text)
                    {

                        //Conexao.Conectar();
                        Conexao.cmdMySQL.CommandText = "INSERT INTO usuario (SenhaUsuario, NomeUsuario,login, Nivel_idNivel) VALUES ('"
                               + txtbNUSenha.Text + "','"
                               + txtbNUNome.Text + "','"
                               + txtbNULogin.Text + "',"
                               + (cbxNivel.SelectedIndex+1)+")";

                        Conexao.cmdMySQL.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        //carregaVars();// para carregar os dados na LisView
                        //btnLimpar.PerformClick();//limpar os dados puxando do botão...


                        //Travar as caixas para aceitar cadastro apenas quando o Botão Novo for pressionado
                       // this.txtCpf.Enabled = false;
                        //this.txtLogin.Enabled = false;
                        //this.txtSenha.Enabled = false;
                        //this.txtConfirmaSenha.Enabled = false;

                       // Conexao.conMySQL.Close();
                    }
                    else
                    {

                        MessageBox.Show("As senhas não correspondem", "OK", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }



        }

        private void btnNUCan_Click(object sender, EventArgs e)
        {

            //new TelaInicial().Visible = true;
            this.Close();

        }
    }
}
