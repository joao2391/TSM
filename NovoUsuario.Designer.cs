namespace TattoSystemManager
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            this.lblNLogin = new System.Windows.Forms.Label();
            this.txtbNULogin = new System.Windows.Forms.TextBox();
            this.gbxNLogin = new System.Windows.Forms.GroupBox();
            this.txtbNUNome = new System.Windows.Forms.TextBox();
            this.lblNUNome = new System.Windows.Forms.Label();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnNUCan = new System.Windows.Forms.Button();
            this.btnNUOk = new System.Windows.Forms.Button();
            this.txtbNUCSenha = new System.Windows.Forms.TextBox();
            this.lblCSenha = new System.Windows.Forms.Label();
            this.txtbNUSenha = new System.Windows.Forms.TextBox();
            this.lblNSenha = new System.Windows.Forms.Label();
            this.lblNTelaNUser = new System.Windows.Forms.Label();
            this.gbxNLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNLogin
            // 
            this.lblNLogin.AutoSize = true;
            this.lblNLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLogin.Location = new System.Drawing.Point(264, 49);
            this.lblNLogin.Name = "lblNLogin";
            this.lblNLogin.Size = new System.Drawing.Size(66, 25);
            this.lblNLogin.TabIndex = 2;
            this.lblNLogin.Text = "Login:";
            // 
            // txtbNULogin
            // 
            this.txtbNULogin.Location = new System.Drawing.Point(336, 53);
            this.txtbNULogin.Name = "txtbNULogin";
            this.txtbNULogin.Size = new System.Drawing.Size(116, 23);
            this.txtbNULogin.TabIndex = 3;
            // 
            // gbxNLogin
            // 
            this.gbxNLogin.Controls.Add(this.txtbNUNome);
            this.gbxNLogin.Controls.Add(this.lblNUNome);
            this.gbxNLogin.Controls.Add(this.cbxNivel);
            this.gbxNLogin.Controls.Add(this.lblNivel);
            this.gbxNLogin.Controls.Add(this.btnNUCan);
            this.gbxNLogin.Controls.Add(this.btnNUOk);
            this.gbxNLogin.Controls.Add(this.txtbNUCSenha);
            this.gbxNLogin.Controls.Add(this.lblCSenha);
            this.gbxNLogin.Controls.Add(this.txtbNUSenha);
            this.gbxNLogin.Controls.Add(this.lblNSenha);
            this.gbxNLogin.Controls.Add(this.txtbNULogin);
            this.gbxNLogin.Controls.Add(this.lblNLogin);
            this.gbxNLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNLogin.Location = new System.Drawing.Point(66, 65);
            this.gbxNLogin.Name = "gbxNLogin";
            this.gbxNLogin.Size = new System.Drawing.Size(590, 229);
            this.gbxNLogin.TabIndex = 4;
            this.gbxNLogin.TabStop = false;
            // 
            // txtbNUNome
            // 
            this.txtbNUNome.Location = new System.Drawing.Point(103, 49);
            this.txtbNUNome.Name = "txtbNUNome";
            this.txtbNUNome.Size = new System.Drawing.Size(115, 23);
            this.txtbNUNome.TabIndex = 13;
            // 
            // lblNUNome
            // 
            this.lblNUNome.AutoSize = true;
            this.lblNUNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUNome.Location = new System.Drawing.Point(27, 45);
            this.lblNUNome.Name = "lblNUNome";
            this.lblNUNome.Size = new System.Drawing.Size(70, 25);
            this.lblNUNome.TabIndex = 12;
            this.lblNUNome.Text = "Nome:";
            // 
            // cbxNivel
            // 
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbxNivel.Location = new System.Drawing.Point(97, 175);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(121, 24);
            this.cbxNivel.TabIndex = 11;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(27, 174);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(61, 25);
            this.lblNivel.TabIndex = 10;
            this.lblNivel.Text = "Nível:";
            // 
            // btnNUCan
            // 
            this.btnNUCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNUCan.Image = ((System.Drawing.Image)(resources.GetObject("btnNUCan.Image")));
            this.btnNUCan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNUCan.Location = new System.Drawing.Point(353, 175);
            this.btnNUCan.Name = "btnNUCan";
            this.btnNUCan.Size = new System.Drawing.Size(99, 36);
            this.btnNUCan.TabIndex = 9;
            this.btnNUCan.Text = "Cancelar";
            this.btnNUCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNUCan.UseVisualStyleBackColor = true;
            this.btnNUCan.Click += new System.EventHandler(this.btnNUCan_Click);
            // 
            // btnNUOk
            // 
            this.btnNUOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNUOk.Image = ((System.Drawing.Image)(resources.GetObject("btnNUOk.Image")));
            this.btnNUOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNUOk.Location = new System.Drawing.Point(269, 175);
            this.btnNUOk.Name = "btnNUOk";
            this.btnNUOk.Size = new System.Drawing.Size(77, 35);
            this.btnNUOk.TabIndex = 8;
            this.btnNUOk.Text = "Salvar";
            this.btnNUOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNUOk.UseVisualStyleBackColor = true;
            this.btnNUOk.Click += new System.EventHandler(this.btnNUOk_Click);
            // 
            // txtbNUCSenha
            // 
            this.txtbNUCSenha.Location = new System.Drawing.Point(410, 113);
            this.txtbNUCSenha.Name = "txtbNUCSenha";
            this.txtbNUCSenha.PasswordChar = '*';
            this.txtbNUCSenha.Size = new System.Drawing.Size(116, 23);
            this.txtbNUCSenha.TabIndex = 7;
            // 
            // lblCSenha
            // 
            this.lblCSenha.AutoSize = true;
            this.lblCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSenha.Location = new System.Drawing.Point(238, 109);
            this.lblCSenha.Name = "lblCSenha";
            this.lblCSenha.Size = new System.Drawing.Size(166, 25);
            this.lblCSenha.TabIndex = 6;
            this.lblCSenha.Text = "Confirmar Senha:";
            // 
            // txtbNUSenha
            // 
            this.txtbNUSenha.Location = new System.Drawing.Point(102, 109);
            this.txtbNUSenha.Name = "txtbNUSenha";
            this.txtbNUSenha.PasswordChar = '*';
            this.txtbNUSenha.Size = new System.Drawing.Size(116, 23);
            this.txtbNUSenha.TabIndex = 5;
            // 
            // lblNSenha
            // 
            this.lblNSenha.AutoSize = true;
            this.lblNSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSenha.Location = new System.Drawing.Point(21, 109);
            this.lblNSenha.Name = "lblNSenha";
            this.lblNSenha.Size = new System.Drawing.Size(76, 25);
            this.lblNSenha.TabIndex = 4;
            this.lblNSenha.Text = "Senha:";
            // 
            // lblNTelaNUser
            // 
            this.lblNTelaNUser.AutoSize = true;
            this.lblNTelaNUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTelaNUser.Location = new System.Drawing.Point(72, 28);
            this.lblNTelaNUser.Name = "lblNTelaNUser";
            this.lblNTelaNUser.Size = new System.Drawing.Size(103, 16);
            this.lblNTelaNUser.TabIndex = 5;
            this.lblNTelaNUser.Text = "Novo Usuário";
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(677, 325);
            this.Controls.Add(this.lblNTelaNUser);
            this.Controls.Add(this.gbxNLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.gbxNLogin.ResumeLayout(false);
            this.gbxNLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNLogin;
        private System.Windows.Forms.TextBox txtbNULogin;
        private System.Windows.Forms.GroupBox gbxNLogin;
        private System.Windows.Forms.Label lblNSenha;
        private System.Windows.Forms.Button btnNUCan;
        private System.Windows.Forms.Button btnNUOk;
        private System.Windows.Forms.TextBox txtbNUCSenha;
        private System.Windows.Forms.Label lblCSenha;
        private System.Windows.Forms.TextBox txtbNUSenha;
        private System.Windows.Forms.ComboBox cbxNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtbNUNome;
        private System.Windows.Forms.Label lblNUNome;
        private System.Windows.Forms.Label lblNTelaNUser;
    }
}