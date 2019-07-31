namespace TattoSystemManager
{
    partial class AlterarDadosUser
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Login");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Senha");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDadosUser));
            this.lstvwAltDadosUser = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtbNivel = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.txtbPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbLupaADU = new System.Windows.Forms.PictureBox();
            this.lblNTelaADU = new System.Windows.Forms.Label();
            this.btnDelUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaADU)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvwAltDadosUser
            // 
            this.lstvwAltDadosUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNivel,
            this.chNome,
            this.chLogin,
            this.chSenha});
            this.lstvwAltDadosUser.FullRowSelect = true;
            this.lstvwAltDadosUser.GridLines = true;
            this.lstvwAltDadosUser.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lstvwAltDadosUser.Location = new System.Drawing.Point(12, 97);
            this.lstvwAltDadosUser.Name = "lstvwAltDadosUser";
            this.lstvwAltDadosUser.Size = new System.Drawing.Size(388, 293);
            this.lstvwAltDadosUser.TabIndex = 2;
            this.lstvwAltDadosUser.UseCompatibleStateImageBehavior = false;
            this.lstvwAltDadosUser.View = System.Windows.Forms.View.Details;
            this.lstvwAltDadosUser.SelectedIndexChanged += new System.EventHandler(this.lstvwAltDadosUser_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 0;
            // 
            // chNivel
            // 
            this.chNivel.Text = "Nivel";
            this.chNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNivel.Width = 76;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNome.Width = 105;
            // 
            // chLogin
            // 
            this.chLogin.Text = "Login";
            this.chLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLogin.Width = 91;
            // 
            // chSenha
            // 
            this.chSenha.Text = "Senha";
            this.chSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSenha.Width = 111;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(442, 97);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(61, 25);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nível:";
            // 
            // txtbNivel
            // 
            this.txtbNivel.Location = new System.Drawing.Point(509, 103);
            this.txtbNivel.Name = "txtbNivel";
            this.txtbNivel.ReadOnly = true;
            this.txtbNivel.Size = new System.Drawing.Size(121, 20);
            this.txtbNivel.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(442, 162);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(509, 167);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(121, 20);
            this.txtbNome.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(442, 214);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(66, 25);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login:";
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(509, 220);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(121, 20);
            this.txtbLogin.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(427, 269);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 25);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtbSenha
            // 
            this.txtbSenha.Location = new System.Drawing.Point(509, 275);
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.Size = new System.Drawing.Size(121, 20);
            this.txtbSenha.TabIndex = 10;
            // 
            // txtbPesquisa
            // 
            this.txtbPesquisa.Location = new System.Drawing.Point(196, 71);
            this.txtbPesquisa.Name = "txtbPesquisa";
            this.txtbPesquisa.Size = new System.Drawing.Size(126, 20);
            this.txtbPesquisa.TabIndex = 11;
            this.txtbPesquisa.TextChanged += new System.EventHandler(this.txtbPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(91, 65);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(99, 25);
            this.lblPesquisa.TabIndex = 12;
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(432, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 35);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(627, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbLupaADU
            // 
            this.pbLupaADU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLupaADU.Image = ((System.Drawing.Image)(resources.GetObject("pbLupaADU.Image")));
            this.pbLupaADU.Location = new System.Drawing.Point(328, 55);
            this.pbLupaADU.Name = "pbLupaADU";
            this.pbLupaADU.Size = new System.Drawing.Size(58, 36);
            this.pbLupaADU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLupaADU.TabIndex = 15;
            this.pbLupaADU.TabStop = false;
            // 
            // lblNTelaADU
            // 
            this.lblNTelaADU.AutoSize = true;
            this.lblNTelaADU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTelaADU.Location = new System.Drawing.Point(71, 33);
            this.lblNTelaADU.Name = "lblNTelaADU";
            this.lblNTelaADU.Size = new System.Drawing.Size(184, 16);
            this.lblNTelaADU.TabIndex = 16;
            this.lblNTelaADU.Text = "Alterar Dados do Usuário";
            // 
            // btnDelUser
            // 
            this.btnDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDelUser.Image")));
            this.btnDelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUser.Location = new System.Drawing.Point(525, 355);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(84, 35);
            this.btnDelUser.TabIndex = 17;
            this.btnDelUser.Text = "Excluir";
            this.btnDelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // AlterarDadosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 397);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.lblNTelaADU);
            this.Controls.Add(this.pbLupaADU);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtbPesquisa);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtbNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lstvwAltDadosUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarDadosUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tatto System Manager";
            this.Load += new System.EventHandler(this.AlterarDadosUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaADU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwAltDadosUser;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNivel;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chLogin;
        private System.Windows.Forms.ColumnHeader chSenha;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtbNivel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.TextBox txtbPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbLupaADU;
        private System.Windows.Forms.Label lblNTelaADU;
        private System.Windows.Forms.Button btnDelUser;
    }
}