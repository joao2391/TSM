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
    public partial class Agendamento : Form
    {

        String status;

        public void limpar()
        {

            txtbANome.Text = "";
            txtbATel.Text = "";
            txtbAEmail.Text = "";
            txtbACpf.Text = "";
            cbbxHora.Text = "";
            dtpData.Text = "";
            txtbValor.Text = "";

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

                lstvwAgenda.Items.Clear();


                if (txtbAPesq.Text == "")
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM cliente ORDER BY nomeCliente ASC";

                }
                else
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM cliente WHERE nomeCliente LIKE '%" + txtbAPesq.Text + "%' ORDER BY nomeCliente ASC";
                }

                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();

                while (Conexao.reader.Read())
                {
                    //Lista os dados do banco na sequência dos atributos.
                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());

                    list.SubItems.Add(Conexao.reader[2].ToString());
                    list.SubItems.Add(Conexao.reader[5].ToString());
                    list.SubItems.Add(Conexao.reader[6].ToString());
                    list.SubItems.Add(Conexao.reader[8].ToString());
                                  
                    

                    lstvwAgenda.Items.AddRange(new ListViewItem[] { list });
                }

                Conexao.conMySQL.Close();
                Conexao.reader.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }






        public Agendamento()
        {
            InitializeComponent();
        }

        private void txtbANome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstvwAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            


            try
            {


                Conexao.Conectar();

                txtbANome.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[1].Text;
                txtbATel.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[2].Text;
                txtbAEmail.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[3].Text;
                txtbACpf.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[0].Text;


            }
            catch (Exception)
            {
                MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Conexao.conMySQL.Close();
            Conexao.reader.Close();

        }

        private void txtbAPesq_TextChanged(object sender, EventArgs e)
        {


            carregaVars();

        }

        private void Agendamento_Load(object sender, EventArgs e)
        {


            dtpData.Text = DateTime.Today.ToShortDateString();

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

        private void btnASalvar_Click(object sender, EventArgs e)
        {


            

            try
            {

                

            Conexao.Conectar();

          

 
                       //NUNCA ESQUEÇA DAS ASPAS SIMPLES E DUPLAS!
                       //NUNCA ESQUEÇA DE PRESTAR ATENÇÃO NAS ASPAS DO FINAL DO "CAMPO.TEXT +" 

                       Conexao.cmdMySQL.CommandText = "INSERT INTO agendamento (fkCliente, dataAgendamento, horaAgendamento, valor) VALUES ('"
                                  
                                  + txtbACpf.Text + "','"
                                  + dtpData.Text + "','"
                                  + cbbxHora.Text + "','"
                                   + Convert.ToDouble(txtbValor.Text)+ "')";

                       Conexao.cmdMySQL.ExecuteNonQuery();
            

                       MessageBox.Show("Cliente agendado com sucesso!", "Salvar", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }

            limpar();

        }

        private void btnACancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            
        }

        



    }
}
