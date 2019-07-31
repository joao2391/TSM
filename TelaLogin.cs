using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;  //-----Conexão com o Banco de Dados MySQL
using MySql.Data; //----Conexão com o Banco de Dados MySQL
using MySql.Data.MySqlClient; //------Conexão com o Banco de Dados MySQL
using System.Windows.Forms; //----Conexão com o Banco de Dados MySQL
using System.Windows.Forms;


namespace TattoSystemManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static String verifLogin, verifSenha,verinivel,userNome;

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }
            

            try
            {
                Conexao.Conectar();
                Conexao.cmdMySQL.CommandText = "Select * from usuario where login = '" + txtbUser.Text + "' and SenhaUsuario = '"
                    + txtbSenha.Text + "';";

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();


                if (Conexao.reader.Read())
                {

                    
                    verifLogin = Conexao.reader["login"].ToString();
                    verifSenha = Conexao.reader["SenhaUsuario"].ToString();
                    verinivel =  Conexao.reader["Nivel_idNivel"].ToString();
                    userNome = Conexao.reader["NomeUsuario"].ToString();

                    new TelaInicial().Visible = true;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Login ou Senha invalido");
                    txtbUser.Text = "";
                    txtbSenha.Text = "";
                }

                Conexao.conMySQL.Close();
                Conexao.reader.Close();


                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro Classe Form1", ex.ToString());
            }


            
            


            
        }
            
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            



            }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtbSenha_TextChanged(object sender, EventArgs e)
        {

            
            

        }



        }
    }