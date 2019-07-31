namespace TattoSystemManager
{
    partial class Agenda
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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Data");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Hora");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Valor");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.lstvwAgenda = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbPesq = new System.Windows.Forms.TextBox();
            this.lblPesq = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNTelaAgenda = new System.Windows.Forms.Label();
            this.btnRemarc = new System.Windows.Forms.Button();
            this.txtbData = new System.Windows.Forms.MaskedTextBox();
            this.txtbHora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAValor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvwAgenda
            // 
            this.lstvwAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chData,
            this.chHora,
            this.chValor});
            this.lstvwAgenda.FullRowSelect = true;
            this.lstvwAgenda.GridLines = true;
            this.lstvwAgenda.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.lstvwAgenda.Location = new System.Drawing.Point(12, 106);
            this.lstvwAgenda.Name = "lstvwAgenda";
            this.lstvwAgenda.Size = new System.Drawing.Size(458, 266);
            this.lstvwAgenda.TabIndex = 0;
            this.lstvwAgenda.UseCompatibleStateImageBehavior = false;
            this.lstvwAgenda.View = System.Windows.Forms.View.Details;
            this.lstvwAgenda.SelectedIndexChanged += new System.EventHandler(this.lstvwAgenda_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 41;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNome.Width = 158;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chData.Width = 99;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHora.Width = 95;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor(R$)";
            this.chValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbPesq
            // 
            this.txtbPesq.Location = new System.Drawing.Point(199, 74);
            this.txtbPesq.Name = "txtbPesq";
            this.txtbPesq.Size = new System.Drawing.Size(100, 20);
            this.txtbPesq.TabIndex = 1;
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.Location = new System.Drawing.Point(95, 69);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(98, 24);
            this.lblPesq.TabIndex = 2;
            this.lblPesq.Text = "Pesquisar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesmarcar.Image")));
            this.btnDesmarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmarcar.Location = new System.Drawing.Point(594, 335);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(97, 37);
            this.btnDesmarcar.TabIndex = 4;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(697, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(513, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID:";
            // 
            // txtbId
            // 
            this.txtbId.Location = new System.Drawing.Point(543, 106);
            this.txtbId.Name = "txtbId";
            this.txtbId.ReadOnly = true;
            this.txtbId.Size = new System.Drawing.Size(30, 20);
            this.txtbId.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(489, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(543, 143);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.ReadOnly = true;
            this.txtbNome.Size = new System.Drawing.Size(127, 20);
            this.txtbNome.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(497, 176);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 16);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(496, 206);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 16);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora:";
            // 
            // lblNTelaAgenda
            // 
            this.lblNTelaAgenda.AutoSize = true;
            this.lblNTelaAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTelaAgenda.Location = new System.Drawing.Point(71, 31);
            this.lblNTelaAgenda.Name = "lblNTelaAgenda";
            this.lblNTelaAgenda.Size = new System.Drawing.Size(62, 16);
            this.lblNTelaAgenda.TabIndex = 14;
            this.lblNTelaAgenda.Text = "Agenda";
            // 
            // btnRemarc
            // 
            this.btnRemarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemarc.Image = ((System.Drawing.Image)(resources.GetObject("btnRemarc.Image")));
            this.btnRemarc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemarc.Location = new System.Drawing.Point(497, 335);
            this.btnRemarc.Name = "btnRemarc";
            this.btnRemarc.Size = new System.Drawing.Size(91, 37);
            this.btnRemarc.TabIndex = 15;
            this.btnRemarc.Text = "Remarcar";
            this.btnRemarc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemarc.UseVisualStyleBackColor = true;
            this.btnRemarc.Click += new System.EventHandler(this.btnRemarc_Click);
            // 
            // txtbData
            // 
            this.txtbData.Location = new System.Drawing.Point(543, 175);
            this.txtbData.Name = "txtbData";
            this.txtbData.Size = new System.Drawing.Size(65, 20);
            this.txtbData.TabIndex = 16;
            // 
            // txtbHora
            // 
            this.txtbHora.Location = new System.Drawing.Point(543, 202);
            this.txtbHora.Name = "txtbHora";
            this.txtbHora.Size = new System.Drawing.Size(39, 20);
            this.txtbHora.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(494, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valor(R$):";
            // 
            // txtbAValor
            // 
            this.txtbAValor.Location = new System.Drawing.Point(558, 238);
            this.txtbAValor.Name = "txtbAValor";
            this.txtbAValor.Size = new System.Drawing.Size(60, 20);
            this.txtbAValor.TabIndex = 19;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 381);
            this.Controls.Add(this.txtbAValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbHora);
            this.Controls.Add(this.txtbData);
            this.Controls.Add(this.btnRemarc);
            this.Controls.Add(this.lblNTelaAgenda);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.txtbPesq);
            this.Controls.Add(this.lstvwAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwAgenda;
        private System.Windows.Forms.TextBox txtbPesq;
        private System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNTelaAgenda;
        private System.Windows.Forms.Button btnRemarc;
        private System.Windows.Forms.MaskedTextBox txtbData;
        private System.Windows.Forms.MaskedTextBox txtbHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtbAValor;
        private System.Windows.Forms.ColumnHeader chValor;
    }
}