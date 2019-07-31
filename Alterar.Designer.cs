namespace TattoSystemManager
{
    partial class Alterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("RG");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("CPF");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Endereço");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Telefone");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Email");
            this.lstvwAlterar = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MStripInicial = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelAlt = new System.Windows.Forms.Button();
            this.txtbPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnEditAlt = new System.Windows.Forms.Button();
            this.btnDelAlt = new System.Windows.Forms.Button();
            this.MStripInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvwAlterar
            // 
            this.lstvwAlterar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chRG,
            this.chCPF,
            this.chEnd,
            this.chTel,
            this.chEmail});
            this.lstvwAlterar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstvwAlterar.Location = new System.Drawing.Point(1, 58);
            this.lstvwAlterar.Name = "lstvwAlterar";
            this.lstvwAlterar.Size = new System.Drawing.Size(615, 351);
            this.lstvwAlterar.TabIndex = 0;
            this.lstvwAlterar.UseCompatibleStateImageBehavior = false;
            this.lstvwAlterar.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 3;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 103;
            // 
            // chRG
            // 
            this.chRG.Text = "RG";
            this.chRG.Width = 102;
            // 
            // chCPF
            // 
            this.chCPF.Text = "CPF";
            this.chCPF.Width = 109;
            // 
            // chEnd
            // 
            this.chEnd.Text = "Endereço";
            this.chEnd.Width = 94;
            // 
            // chTel
            // 
            this.chTel.Text = "Telefone";
            this.chTel.Width = 93;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 107;
            // 
            // MStripInicial
            // 
            this.MStripInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.MStripInicial.Location = new System.Drawing.Point(0, 0);
            this.MStripInicial.Name = "MStripInicial";
            this.MStripInicial.Size = new System.Drawing.Size(781, 24);
            this.MStripInicial.TabIndex = 1;
            this.MStripInicial.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.alterarToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.alterarToolStripMenuItem1.Text = "Alterar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.novoUsuárioToolStripMenuItem,
            this.removerUsuárioToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            // 
            // removerUsuárioToolStripMenuItem
            // 
            this.removerUsuárioToolStripMenuItem.Name = "removerUsuárioToolStripMenuItem";
            this.removerUsuárioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removerUsuárioToolStripMenuItem.Text = "Remover Usuário";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarWallpaperToolStripMenuItem,
            this.alterarCorToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // alterarWallpaperToolStripMenuItem
            // 
            this.alterarWallpaperToolStripMenuItem.Name = "alterarWallpaperToolStripMenuItem";
            this.alterarWallpaperToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alterarWallpaperToolStripMenuItem.Text = "Alterar Wallpaper";
            // 
            // alterarCorToolStripMenuItem
            // 
            this.alterarCorToolStripMenuItem.Name = "alterarCorToolStripMenuItem";
            this.alterarCorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alterarCorToolStripMenuItem.Text = "Alterar Cor";
            // 
            // btnCancelAlt
            // 
            this.btnCancelAlt.Location = new System.Drawing.Point(645, 444);
            this.btnCancelAlt.Name = "btnCancelAlt";
            this.btnCancelAlt.Size = new System.Drawing.Size(113, 35);
            this.btnCancelAlt.TabIndex = 2;
            this.btnCancelAlt.Text = "Cancelar";
            this.btnCancelAlt.UseVisualStyleBackColor = true;
            // 
            // txtbPesquisa
            // 
            this.txtbPesquisa.Location = new System.Drawing.Point(645, 94);
            this.txtbPesquisa.Name = "txtbPesquisa";
            this.txtbPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtbPesquisa.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(659, 120);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnEditAlt
            // 
            this.btnEditAlt.Location = new System.Drawing.Point(636, 189);
            this.btnEditAlt.Name = "btnEditAlt";
            this.btnEditAlt.Size = new System.Drawing.Size(75, 23);
            this.btnEditAlt.TabIndex = 5;
            this.btnEditAlt.Text = "Editar";
            this.btnEditAlt.UseVisualStyleBackColor = true;
            // 
            // btnDelAlt
            // 
            this.btnDelAlt.Location = new System.Drawing.Point(636, 231);
            this.btnDelAlt.Name = "btnDelAlt";
            this.btnDelAlt.Size = new System.Drawing.Size(75, 23);
            this.btnDelAlt.TabIndex = 6;
            this.btnDelAlt.Text = "Excluir";
            this.btnDelAlt.UseVisualStyleBackColor = true;
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(781, 491);
            this.Controls.Add(this.btnDelAlt);
            this.Controls.Add(this.btnEditAlt);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtbPesquisa);
            this.Controls.Add(this.btnCancelAlt);
            this.Controls.Add(this.MStripInicial);
            this.Controls.Add(this.lstvwAlterar);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.MStripInicial.ResumeLayout(false);
            this.MStripInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwAlterar;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chRG;
        private System.Windows.Forms.ColumnHeader chCPF;
        private System.Windows.Forms.ColumnHeader chEnd;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.MenuStrip MStripInicial;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCorToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelAlt;
        private System.Windows.Forms.TextBox txtbPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnEditAlt;
        private System.Windows.Forms.Button btnDelAlt;

    }
}