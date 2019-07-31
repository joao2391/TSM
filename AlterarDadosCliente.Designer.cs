namespace TattoSystemManager
{
    partial class AlterarDadosCliente
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Endereço");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Telefone");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Email");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("DataNasc.");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Informações");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDadosCliente));
            this.lstvwAlterar = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDtNasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelAlt = new System.Windows.Forms.Button();
            this.txtbPesquisa = new System.Windows.Forms.TextBox();
            this.btnSalvAlt = new System.Windows.Forms.Button();
            this.lblAltNome = new System.Windows.Forms.Label();
            this.txtbAltNome = new System.Windows.Forms.TextBox();
            this.lblAltRG = new System.Windows.Forms.Label();
            this.txtbAltRG = new System.Windows.Forms.TextBox();
            this.lblAltEnd = new System.Windows.Forms.Label();
            this.txtbAltEnd = new System.Windows.Forms.TextBox();
            this.lblAltTel = new System.Windows.Forms.Label();
            this.lblAltEmail = new System.Windows.Forms.Label();
            this.txtbAltEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPesq = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtbInfo = new System.Windows.Forms.TextBox();
            this.btnDelCli = new System.Windows.Forms.Button();
            this.pcLupa = new System.Windows.Forms.PictureBox();
            this.lblNTela = new System.Windows.Forms.Label();
            this.lblARg = new System.Windows.Forms.Label();
            this.txtbAltTel = new System.Windows.Forms.MaskedTextBox();
            this.txtbAltDtNasc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvwAlterar
            // 
            this.lstvwAlterar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chRG,
            this.chEnd,
            this.chTel,
            this.chEmail,
            this.chDtNasc,
            this.chInfo});
            this.lstvwAlterar.FullRowSelect = true;
            this.lstvwAlterar.GridLines = true;
            this.lstvwAlterar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lstvwAlterar.Location = new System.Drawing.Point(39, 71);
            this.lstvwAlterar.Name = "lstvwAlterar";
            this.lstvwAlterar.Size = new System.Drawing.Size(679, 318);
            this.lstvwAlterar.TabIndex = 0;
            this.lstvwAlterar.UseCompatibleStateImageBehavior = false;
            this.lstvwAlterar.View = System.Windows.Forms.View.Details;
            this.lstvwAlterar.SelectedIndexChanged += new System.EventHandler(this.lstvwAlterar_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 0;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 102;
            // 
            // chRG
            // 
            this.chRG.Text = "RG";
            this.chRG.Width = 102;
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
            // chDtNasc
            // 
            this.chDtNasc.Text = "DataNasc.";
            this.chDtNasc.Width = 67;
            // 
            // chInfo
            // 
            this.chInfo.Text = "Informações";
            this.chInfo.Width = 110;
            // 
            // btnCancelAlt
            // 
            this.btnCancelAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAlt.Image")));
            this.btnCancelAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAlt.Location = new System.Drawing.Point(1046, 308);
            this.btnCancelAlt.Name = "btnCancelAlt";
            this.btnCancelAlt.Size = new System.Drawing.Size(97, 35);
            this.btnCancelAlt.TabIndex = 2;
            this.btnCancelAlt.Text = "Cancelar";
            this.btnCancelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAlt.UseVisualStyleBackColor = true;
            this.btnCancelAlt.Click += new System.EventHandler(this.btnCancelAlt_Click);
            // 
            // txtbPesquisa
            // 
            this.txtbPesquisa.Location = new System.Drawing.Point(500, 35);
            this.txtbPesquisa.Name = "txtbPesquisa";
            this.txtbPesquisa.Size = new System.Drawing.Size(112, 20);
            this.txtbPesquisa.TabIndex = 3;
            this.txtbPesquisa.TextChanged += new System.EventHandler(this.txtbPesquisa_TextChanged);
            // 
            // btnSalvAlt
            // 
            this.btnSalvAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvAlt.Image")));
            this.btnSalvAlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvAlt.Location = new System.Drawing.Point(764, 308);
            this.btnSalvAlt.Name = "btnSalvAlt";
            this.btnSalvAlt.Size = new System.Drawing.Size(94, 35);
            this.btnSalvAlt.TabIndex = 6;
            this.btnSalvAlt.Text = "Salvar";
            this.btnSalvAlt.UseVisualStyleBackColor = true;
            this.btnSalvAlt.Click += new System.EventHandler(this.btnSalvAlt_Click);
            // 
            // lblAltNome
            // 
            this.lblAltNome.AutoSize = true;
            this.lblAltNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltNome.Location = new System.Drawing.Point(740, 66);
            this.lblAltNome.Name = "lblAltNome";
            this.lblAltNome.Size = new System.Drawing.Size(70, 25);
            this.lblAltNome.TabIndex = 7;
            this.lblAltNome.Text = "Nome:";
            // 
            // txtbAltNome
            // 
            this.txtbAltNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtbAltNome.Location = new System.Drawing.Point(816, 71);
            this.txtbAltNome.Name = "txtbAltNome";
            this.txtbAltNome.Size = new System.Drawing.Size(150, 20);
            this.txtbAltNome.TabIndex = 8;
            // 
            // lblAltRG
            // 
            this.lblAltRG.AutoSize = true;
            this.lblAltRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltRG.Location = new System.Drawing.Point(994, 66);
            this.lblAltRG.Name = "lblAltRG";
            this.lblAltRG.Size = new System.Drawing.Size(46, 25);
            this.lblAltRG.TabIndex = 9;
            this.lblAltRG.Text = "RG:";
            // 
            // txtbAltRG
            // 
            this.txtbAltRG.Location = new System.Drawing.Point(1046, 71);
            this.txtbAltRG.MaxLength = 9;
            this.txtbAltRG.Name = "txtbAltRG";
            this.txtbAltRG.Size = new System.Drawing.Size(66, 20);
            this.txtbAltRG.TabIndex = 10;
            // 
            // lblAltEnd
            // 
            this.lblAltEnd.AutoSize = true;
            this.lblAltEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltEnd.Location = new System.Drawing.Point(752, 105);
            this.lblAltEnd.Name = "lblAltEnd";
            this.lblAltEnd.Size = new System.Drawing.Size(58, 25);
            this.lblAltEnd.TabIndex = 13;
            this.lblAltEnd.Text = "End.:";
            // 
            // txtbAltEnd
            // 
            this.txtbAltEnd.Location = new System.Drawing.Point(816, 110);
            this.txtbAltEnd.Name = "txtbAltEnd";
            this.txtbAltEnd.Size = new System.Drawing.Size(150, 20);
            this.txtbAltEnd.TabIndex = 14;
            // 
            // lblAltTel
            // 
            this.lblAltTel.AutoSize = true;
            this.lblAltTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltTel.Location = new System.Drawing.Point(759, 139);
            this.lblAltTel.Name = "lblAltTel";
            this.lblAltTel.Size = new System.Drawing.Size(51, 25);
            this.lblAltTel.TabIndex = 15;
            this.lblAltTel.Text = "Tel.:";
            // 
            // lblAltEmail
            // 
            this.lblAltEmail.AutoSize = true;
            this.lblAltEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltEmail.Location = new System.Drawing.Point(964, 140);
            this.lblAltEmail.Name = "lblAltEmail";
            this.lblAltEmail.Size = new System.Drawing.Size(66, 25);
            this.lblAltEmail.TabIndex = 17;
            this.lblAltEmail.Text = "Email:";
            // 
            // txtbAltEmail
            // 
            this.txtbAltEmail.Location = new System.Drawing.Point(1036, 145);
            this.txtbAltEmail.Name = "txtbAltEmail";
            this.txtbAltEmail.Size = new System.Drawing.Size(107, 20);
            this.txtbAltEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(987, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "D.Nasc.:";
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPesq.Location = new System.Drawing.Point(389, 30);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(105, 25);
            this.lblPesq.TabIndex = 21;
            this.lblPesq.Text = "Pesquisar:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(759, 192);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(55, 25);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Info.:";
            // 
            // txtbInfo
            // 
            this.txtbInfo.Location = new System.Drawing.Point(816, 180);
            this.txtbInfo.Multiline = true;
            this.txtbInfo.Name = "txtbInfo";
            this.txtbInfo.Size = new System.Drawing.Size(202, 78);
            this.txtbInfo.TabIndex = 23;
            // 
            // btnDelCli
            // 
            this.btnDelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCli.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCli.Image")));
            this.btnDelCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCli.Location = new System.Drawing.Point(906, 308);
            this.btnDelCli.Name = "btnDelCli";
            this.btnDelCli.Size = new System.Drawing.Size(98, 35);
            this.btnDelCli.TabIndex = 24;
            this.btnDelCli.Text = "Excluir";
            this.btnDelCli.UseVisualStyleBackColor = true;
            this.btnDelCli.Click += new System.EventHandler(this.btnDelCli_Click);
            // 
            // pcLupa
            // 
            this.pcLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcLupa.Image = ((System.Drawing.Image)(resources.GetObject("pcLupa.Image")));
            this.pcLupa.Location = new System.Drawing.Point(618, 23);
            this.pcLupa.Name = "pcLupa";
            this.pcLupa.Size = new System.Drawing.Size(49, 43);
            this.pcLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLupa.TabIndex = 25;
            this.pcLupa.TabStop = false;
            // 
            // lblNTela
            // 
            this.lblNTela.AutoSize = true;
            this.lblNTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTela.Location = new System.Drawing.Point(47, 36);
            this.lblNTela.Name = "lblNTela";
            this.lblNTela.Size = new System.Drawing.Size(212, 16);
            this.lblNTela.TabIndex = 26;
            this.lblNTela.Text = "Consulta/Alteração de Dados";
            // 
            // lblARg
            // 
            this.lblARg.AutoSize = true;
            this.lblARg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARg.ForeColor = System.Drawing.Color.Red;
            this.lblARg.Location = new System.Drawing.Point(1118, 75);
            this.lblARg.Name = "lblARg";
            this.lblARg.Size = new System.Drawing.Size(96, 13);
            this.lblARg.TabIndex = 27;
            this.lblARg.Text = "*(Apenas números)";
            // 
            // txtbAltTel
            // 
            this.txtbAltTel.Location = new System.Drawing.Point(816, 144);
            this.txtbAltTel.Name = "txtbAltTel";
            this.txtbAltTel.Size = new System.Drawing.Size(86, 20);
            this.txtbAltTel.TabIndex = 28;
            // 
            // txtbAltDtNasc
            // 
            this.txtbAltDtNasc.Location = new System.Drawing.Point(1076, 109);
            this.txtbAltDtNasc.Name = "txtbAltDtNasc";
            this.txtbAltDtNasc.Size = new System.Drawing.Size(67, 20);
            this.txtbAltDtNasc.TabIndex = 29;
            // 
            // AlterarDadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1215, 393);
            this.Controls.Add(this.txtbAltDtNasc);
            this.Controls.Add(this.txtbAltTel);
            this.Controls.Add(this.lblARg);
            this.Controls.Add(this.lblNTela);
            this.Controls.Add(this.pcLupa);
            this.Controls.Add(this.btnDelCli);
            this.Controls.Add(this.txtbInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAltEmail);
            this.Controls.Add(this.lblAltEmail);
            this.Controls.Add(this.lblAltTel);
            this.Controls.Add(this.txtbAltEnd);
            this.Controls.Add(this.lblAltEnd);
            this.Controls.Add(this.txtbAltRG);
            this.Controls.Add(this.lblAltRG);
            this.Controls.Add(this.txtbAltNome);
            this.Controls.Add(this.lblAltNome);
            this.Controls.Add(this.btnSalvAlt);
            this.Controls.Add(this.txtbPesquisa);
            this.Controls.Add(this.btnCancelAlt);
            this.Controls.Add(this.lstvwAlterar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarDadosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.Load += new System.EventHandler(this.AlterarDadosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwAlterar;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chRG;
        private System.Windows.Forms.ColumnHeader chEnd;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.Button btnCancelAlt;
        private System.Windows.Forms.TextBox txtbPesquisa;
        private System.Windows.Forms.Button btnSalvAlt;
        private System.Windows.Forms.Label lblAltNome;
        private System.Windows.Forms.TextBox txtbAltNome;
        private System.Windows.Forms.Label lblAltRG;
        private System.Windows.Forms.TextBox txtbAltRG;
        private System.Windows.Forms.Label lblAltEnd;
        private System.Windows.Forms.TextBox txtbAltEnd;
        private System.Windows.Forms.Label lblAltTel;
        private System.Windows.Forms.Label lblAltEmail;
        private System.Windows.Forms.TextBox txtbAltEmail;
        private System.Windows.Forms.ColumnHeader chDtNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chInfo;
        private System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtbInfo;
        private System.Windows.Forms.Button btnDelCli;
        private System.Windows.Forms.PictureBox pcLupa;
        private System.Windows.Forms.Label lblNTela;
        private System.Windows.Forms.Label lblARg;
        private System.Windows.Forms.MaskedTextBox txtbAltTel;
        private System.Windows.Forms.MaskedTextBox txtbAltDtNasc;

    }
}