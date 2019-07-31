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
    public partial class CadastrarCliente : Form
    {

        //Fazer IF para verificar cpf no banco!

        public CadastrarCliente()
        {
            InitializeComponent();
        }



        public void limpar()
        {

            txtbNome.Text = "";
            txtbRg.Text = "";
            txtbCpf.Text = "";
            txtbEnd.Text = "";
            txtbDtnasc.Text = "";
            txtbTel.Text = "";
            txtbEmail.Text = "";
            txtbInfo.Text = "";



        }




        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            //---------------------------------------------
            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }
            

            try
            {

                Conexao.Conectar();

                if (txtbNome.Text == "")
                {

                    MessageBox.Show("Informe o nome do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNome.Focus();
                }

                else if(txtbRg.Text == ""){

                    MessageBox.Show("Informe o RG do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbRg.Focus();

                }

                else if (txtbCpf.Text == "")
                {
                    MessageBox.Show("Informe o CPF do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbCpf.Focus();

                }

                else if(txtbEnd.Text == ""){

                    MessageBox.Show("Informe o endereço do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbEnd.Focus();

                }

                else if (txtbDtnasc.Text == "")
                {

                    MessageBox.Show("Informe a data de nascimento do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbDtnasc.Focus();
                }

                else if(txtbTel.Text == ""){

                    MessageBox.Show("Informe o telefone do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbTel.Focus();
                }

                else if (txtbEmail.Text == ""){

                    MessageBox.Show("Informe o email do cliente!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbEmail.Focus();
                }
                                         
                    
                    //NUNCA ESQUEÇA DAS ASPAS SIMPLES E DUPLAS!


                String cpf, vcpf;
                vcpf = txtbCpf.Text;

                Conexao.cmdMySQL.CommandText = "SELECT CPF FROM cliente";

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();



                if (Conexao.reader.Read())
                {

                    cpf = Conexao.reader["CPF"].ToString();


                    if (cpf == vcpf)
                    {

                        MessageBox.Show("Este CPF já existe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }    //IF(cpf==vcpf)
                    else
                    {

                        if (Conexao.conMySQL.State == ConnectionState.Open)
                        {

                            Conexao.conMySQL.Close();
                        }

                        Conexao.Conectar();


                     
                                    
                    Conexao.cmdMySQL.CommandText = "INSERT INTO cliente (CPF ,NomeCliente, Endereco, DataNasc, Telefone, emailCliente, rgCliente,observacao) VALUES ('"
                               + txtbCpf.Text + "','"
                               + txtbNome.Text + "','"
                               + txtbEnd.Text + "','"
                               + txtbDtnasc.Text + "','"
                               + txtbTel.Text + "','"
                               + txtbEmail.Text + "','"
                               + txtbRg.Text +  "','"
                               + txtbInfo.Text + "')";


                    Conexao.cmdMySQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Salvar", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                    } //else do comando acima.


                } // if da conexao.read()

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }

            Conexao.reader.Close();
            Conexao.conMySQL.Close();


            limpar();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }


       

        
    }
}
