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
    public partial class Agenda : Form
    {


        

        String status;

        public void limpar()
        {


            txtbId.Text = "";
            txtbNome.Text = "";
            txtbData.Text = "";
            txtbHora.Text = "";
            txtbAValor.Text = "";


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


                if (txtbPesq.Text == "")
                {

                    Conexao.cmdMySQL.CommandText = "SELECT idAgendamento,NomeCliente,dataAgendamento,horaAgendamento,valor FROM cliente,agendamento WHERE idCliente = fkCliente";
                    // ORDER BY idAgendamento ASC
                    //Conexao.cmdMySQL.Dispose();
                   


                }
                else
                {

                    Conexao.cmdMySQL.CommandText = "SELECT *FROM agendamento WHERE idAgendamento LIKE '%" + txtbPesq.Text + "%' ORDER BY idAgendamento ASC";
                    //Conexao.cmdMySQL.Dispose();
                    //Conexao.cmdMySQL.ExecuteNonQuery();
                }


                Conexao.reader = Conexao.cmdMySQL.ExecuteReader();
                

                while (Conexao.reader.Read())
                {

                    

                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());

                    list.SubItems.Add(Conexao.reader[1].ToString());
                    list.SubItems.Add(Conexao.reader[2].ToString());
                    list.SubItems.Add(Conexao.reader[3].ToString());
                    list.SubItems.Add(Conexao.reader[4].ToString());
                    
                    lstvwAgenda.Items.AddRange(new ListViewItem[] { list });

                    
                }



                Conexao.reader.Close();
                Conexao.conMySQL.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
                

        }

        public Agenda()
        {
            InitializeComponent();
        }

        private void lstvwAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                Conexao.Conectar();


                txtbId.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[0].Text;
                txtbNome.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[1].Text;
                txtbData.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[2].Text;
                txtbHora.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[3].Text;
                txtbAValor.Text = lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].SubItems[4].Text;



                Conexao.reader.Close();
                Conexao.conMySQL.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existem registro na lista .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Agenda_Load(object sender, EventArgs e)
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

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Deseja desmarcar esse cliente?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    Conexao.Conectar();

                    Conexao.cmdMySQL.CommandText = "DELETE FROM agendamento WHERE idAgendamento='" + lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].Text + "'";

                    Conexao.cmdMySQL.ExecuteNonQuery();

                    MessageBox.Show("Cliente deletado com sucesso.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    carregaVars();

                    limpar();


                    Conexao.reader.Close();
                    Conexao.conMySQL.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }




            }



        }

        private void btnRemarc_Click(object sender, EventArgs e)
        {

            if (Conexao.conMySQL.State == ConnectionState.Open)
            {

                Conexao.conMySQL.Close();
            }

            try
            {

                Conexao.Conectar();

                Conexao.cmdMySQL.CommandText = "UPDATE agendamento SET dataAgendamento = '" + txtbData.Text + "',horaAgendamento='" + txtbHora.Text + "',valor='" + txtbAValor.Text + "'WHERE idAgendamento = '" + lstvwAgenda.Items[lstvwAgenda.FocusedItem.Index].Text + "'";
            Conexao.cmdMySQL.ExecuteNonQuery();

            MessageBox.Show("Agenda Alterada com Sucesso.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaVars();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

         
    }
}
