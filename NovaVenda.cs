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
    public partial class NovaVenda : Form
    {

        String status;

        public void mostrarTotal()
        {


           
            try
            {

                Conexao.Conectar();

                Conexao.cmdMySQL.CommandText = "SELECT SUM(valor) FROM agendamento";
                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while(Conexao.reader.Read()){


                    txtbTotal.Text = Conexao.reader[0].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            Conexao.conMySQL.Close();
            Conexao.reader.Close();

        }      
        

        

        public void carregaVars()
        {

            //Falta verificação de cpf, relatorio das vendas em .pdf


            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }

            try
            {


                Conexao.Conectar();

                lstvwVenda.Items.Clear();




                Conexao.cmdMySQL.CommandText = "SELECT idAgendamento,NomeCliente,valor FROM cliente,agendamento WHERE idCliente = fkCliente";
                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while (Conexao.reader.Read())
                {

                   


                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());

                    list.SubItems.Add(Conexao.reader[1].ToString());

                   list.SubItems.Add(Conexao.reader[2].ToString());

                    


                    lstvwVenda.Items.AddRange(new ListViewItem[] { list });



                }

                Conexao.conMySQL.Close();
                Conexao.reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            //Conexao.conMySQL.Close();
            //Conexao.reader.Close();
        }


        public NovaVenda()
        {
            InitializeComponent();
        }

        private void lstvwVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            ////Acho que não vai precisar!
            //try
            //{


            //    Conexao.Conectar();




            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {

           

            try
            {


                carregaVars();
                mostrarTotal();

                status = "novo";

               // Conexao.cmdMySQL.CommandText = "SELECT SUM(valor) FROM agendamento";

            }
            catch (Exception)
            {
                MessageBox.Show(" ERRO! ");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
