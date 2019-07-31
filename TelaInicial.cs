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
    public partial class TelaInicial : Form
    {

        
        public TelaInicial()
        {
            InitializeComponent();
            
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

            lblNUser.Text = FrmLogin.userNome;
            

            if (FrmLogin.verinivel =="2")
            {

                opçõesToolStripMenuItem.Visible = false;
            }



            lblData.Text = DateTime.Today.ToLongDateString();
           // ststripInicial.Text = DateTime.Now.ToShortTimeString();
            
            

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NovoUsuario nu = new NovoUsuario();

            nu.ShowDialog();

            //new NovoUsuario().Visible = true;
            

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastrarCliente cc = new CadastrarCliente();

            cc.ShowDialog();

            //this.Visible = false;
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AlterarDadosCliente adc = new AlterarDadosCliente();

            adc.ShowDialog();
            
            //new AlterarDadosCliente().Visible = true;
            //this.Visible = false;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConsultarProduto cp = new ConsultarProduto();

            cp.ShowDialog();
            
            //new ConsultarProduto().Visible = true;
            //this.Visible = false;
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AlterarDadosUser adu = new AlterarDadosUser();

            adu.ShowDialog();
            
            //new AlterarDadosUser().Visible = true;
            //this.Visible = false;
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            CadastrarProduto cdp = new CadastrarProduto();

            cdp.ShowDialog();
            
            //new CadastrarProduto().Visible = true;
            //this.Visible = false;
        }

        private void lblNUser_Click(object sender, EventArgs e)
        {

            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FrmLogin().Visible = true;
            this.Visible = false;

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Agendamento agto = new Agendamento();

            agto.ShowDialog();
            
            //new Agendamento().Visible = true;
            

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Agenda agenda = new Agenda();

            agenda.ShowDialog();

        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NovaVenda nv = new NovaVenda();

            nv.ShowDialog();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sobre abt = new Sobre();

            abt.ShowDialog();

        }


             


    }
}
