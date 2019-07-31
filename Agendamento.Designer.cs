namespace TattoSystemManager
{
    partial class Agendamento
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Telefone");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Email");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("DataNasc.");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Informações");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.lstvwAgenda = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbANome = new System.Windows.Forms.TextBox();
            this.txtbATel = new System.Windows.Forms.TextBox();
            this.lblANome = new System.Windows.Forms.Label();
            this.lblATel = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.cbbxHora = new System.Windows.Forms.ComboBox();
            this.btnASalvar = new System.Windows.Forms.Button();
            this.btnACancel = new System.Windows.Forms.Button();
            this.lblAEmail = new System.Windows.Forms.Label();
            this.txtbAEmail = new System.Windows.Forms.TextBox();
            this.lblAPesq = new System.Windows.Forms.Label();
            this.txtbAPesq = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblACpf = new System.Windows.Forms.Label();
            this.txtbACpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLupaAgen = new System.Windows.Forms.PictureBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaAgen)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvwAgenda
            // 
            this.lstvwAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chTel,
            this.chEmail,
            this.chInfo});
            this.lstvwAgenda.FullRowSelect = true;
            this.lstvwAgenda.GridLines = true;
            this.lstvwAgenda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.lstvwAgenda.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstvwAgenda.Location = new System.Drawing.Point(12, 102);
            this.lstvwAgenda.Name = "lstvwAgenda";
            this.lstvwAgenda.Size = new System.Drawing.Size(730, 192);
            this.lstvwAgenda.TabIndex = 0;
            this.lstvwAgenda.UseCompatibleStateImageBehavior = false;
            this.lstvwAgenda.View = System.Windows.Forms.View.Details;
            this.lstvwAgenda.SelectedIndexChanged += new System.EventHandler(this.lstvwAgenda_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.DisplayIndex = 4;
            this.chId.Text = "ID";
            this.chId.Width = 85;
            // 
            // chNome
            // 
            this.chNome.DisplayIndex = 0;
            this.chNome.Text = "Nome";
            this.chNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNome.Width = 172;
            // 
            // chTel
            // 
            this.chTel.DisplayIndex = 1;
            this.chTel.Text = "Telefone";
            this.chTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTel.Width = 131;
            // 
            // chEmail
            // 
            this.chEmail.DisplayIndex = 2;
            this.chEmail.Text = "Email";
            this.chEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmail.Width = 142;
            // 
            // chInfo
            // 
            this.chInfo.DisplayIndex = 3;
            this.chInfo.Text = "Informações";
            this.chInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chInfo.Width = 196;
            // 
            // txtbANome
            // 
            this.txtbANome.Location = new System.Drawing.Point(800, 31);
            this.txtbANome.Name = "txtbANome";
            this.txtbANome.ReadOnly = true;
            this.txtbANome.Size = new System.Drawing.Size(122, 20);
            this.txtbANome.TabIndex = 1;
            this.txtbANome.TextChanged += new System.EventHandler(this.txtbANome_TextChanged);
            // 
            // txtbATel
            // 
            this.txtbATel.Location = new System.Drawing.Point(1014, 32);
            this.txtbATel.Name = "txtbATel";
            this.txtbATel.ReadOnly = true;
            this.txtbATel.Size = new System.Drawing.Size(122, 20);
            this.txtbATel.TabIndex = 2;
            // 
            // lblANome
            // 
            this.lblANome.AutoSize = true;
            this.lblANome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANome.Location = new System.Drawing.Point(745, 30);
            this.lblANome.Name = "lblANome";
            this.lblANome.Size = new System.Drawing.Size(49, 17);
            this.lblANome.TabIndex = 3;
            this.lblANome.Text = "Nome:";
            // 
            // lblATel
            // 
            this.lblATel.AutoSize = true;
            this.lblATel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATel.Location = new System.Drawing.Point(940, 32);
            this.lblATel.Name = "lblATel";
            this.lblATel.Size = new System.Drawing.Size(68, 17);
            this.lblATel.TabIndex = 4;
            this.lblATel.Text = "Telefone:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(960, 136);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 25);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Horário:";
            // 
            // cbbxHora
            // 
            this.cbbxHora.FormattingEnabled = true;
            this.cbbxHora.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbbxHora.Location = new System.Drawing.Point(1057, 139);
            this.cbbxHora.Name = "cbbxHora";
            this.cbbxHora.Size = new System.Drawing.Size(79, 21);
            this.cbbxHora.TabIndex = 10;
            // 
            // btnASalvar
            // 
            this.btnASalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnASalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnASalvar.Image")));
            this.btnASalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnASalvar.Location = new System.Drawing.Point(830, 256);
            this.btnASalvar.Name = "btnASalvar";
            this.btnASalvar.Size = new System.Drawing.Size(67, 38);
            this.btnASalvar.TabIndex = 11;
            this.btnASalvar.Text = "Salvar";
            this.btnASalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnASalvar.UseVisualStyleBackColor = true;
            this.btnASalvar.Click += new System.EventHandler(this.btnASalvar_Click);
            // 
            // btnACancel
            // 
            this.btnACancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACancel.Image = ((System.Drawing.Image)(resources.GetObject("btnACancel.Image")));
            this.btnACancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACancel.Location = new System.Drawing.Point(965, 254);
            this.btnACancel.Name = "btnACancel";
            this.btnACancel.Size = new System.Drawing.Size(88, 38);
            this.btnACancel.TabIndex = 13;
            this.btnACancel.Text = "Cancelar";
            this.btnACancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnACancel.UseVisualStyleBackColor = true;
            this.btnACancel.Click += new System.EventHandler(this.btnACancel_Click);
            // 
            // lblAEmail
            // 
            this.lblAEmail.AutoSize = true;
            this.lblAEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEmail.Location = new System.Drawing.Point(748, 67);
            this.lblAEmail.Name = "lblAEmail";
            this.lblAEmail.Size = new System.Drawing.Size(46, 17);
            this.lblAEmail.TabIndex = 14;
            this.lblAEmail.Text = "Email:";
            // 
            // txtbAEmail
            // 
            this.txtbAEmail.Location = new System.Drawing.Point(800, 67);
            this.txtbAEmail.Name = "txtbAEmail";
            this.txtbAEmail.ReadOnly = true;
            this.txtbAEmail.Size = new System.Drawing.Size(122, 20);
            this.txtbAEmail.TabIndex = 15;
            // 
            // lblAPesq
            // 
            this.lblAPesq.AutoSize = true;
            this.lblAPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPesq.Location = new System.Drawing.Point(247, 67);
            this.lblAPesq.Name = "lblAPesq";
            this.lblAPesq.Size = new System.Drawing.Size(105, 25);
            this.lblAPesq.TabIndex = 16;
            this.lblAPesq.Text = "Pesquisar:";
            // 
            // txtbAPesq
            // 
            this.txtbAPesq.Location = new System.Drawing.Point(349, 73);
            this.txtbAPesq.Name = "txtbAPesq";
            this.txtbAPesq.Size = new System.Drawing.Size(131, 20);
            this.txtbAPesq.TabIndex = 17;
            this.txtbAPesq.TextChanged += new System.EventHandler(this.txtbAPesq_TextChanged);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(830, 139);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 18;
            this.dtpData.Value = new System.DateTime(2014, 10, 25, 15, 15, 9, 0);
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(765, 134);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 25);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data:";
            // 
            // lblACpf
            // 
            this.lblACpf.AutoSize = true;
            this.lblACpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACpf.Location = new System.Drawing.Point(940, 67);
            this.lblACpf.Name = "lblACpf";
            this.lblACpf.Size = new System.Drawing.Size(25, 17);
            this.lblACpf.TabIndex = 20;
            this.lblACpf.Text = "ID:";
            // 
            // txtbACpf
            // 
            this.txtbACpf.Location = new System.Drawing.Point(984, 66);
            this.txtbACpf.Name = "txtbACpf";
            this.txtbACpf.ReadOnly = true;
            this.txtbACpf.Size = new System.Drawing.Size(122, 20);
            this.txtbACpf.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Agendamento";
            // 
            // pbLupaAgen
            // 
            this.pbLupaAgen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLupaAgen.Image = ((System.Drawing.Image)(resources.GetObject("pbLupaAgen.Image")));
            this.pbLupaAgen.Location = new System.Drawing.Point(486, 67);
            this.pbLupaAgen.Name = "pbLupaAgen";
            this.pbLupaAgen.Size = new System.Drawing.Size(60, 35);
            this.pbLupaAgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLupaAgen.TabIndex = 23;
            this.pbLupaAgen.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(760, 178);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(102, 25);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor(R$):";
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(855, 183);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(67, 20);
            this.txtbValor.TabIndex = 25;
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1148, 304);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pbLupaAgen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbACpf);
            this.Controls.Add(this.lblACpf);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtbAPesq);
            this.Controls.Add(this.lblAPesq);
            this.Controls.Add(this.txtbAEmail);
            this.Controls.Add(this.lblAEmail);
            this.Controls.Add(this.btnACancel);
            this.Controls.Add(this.btnASalvar);
            this.Controls.Add(this.cbbxHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblATel);
            this.Controls.Add(this.lblANome);
            this.Controls.Add(this.txtbATel);
            this.Controls.Add(this.txtbANome);
            this.Controls.Add(this.lstvwAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLupaAgen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwAgenda;
        private System.Windows.Forms.TextBox txtbANome;
        private System.Windows.Forms.TextBox txtbATel;
        private System.Windows.Forms.Label lblANome;
        private System.Windows.Forms.Label lblATel;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cbbxHora;
        private System.Windows.Forms.Button btnASalvar;
        private System.Windows.Forms.Button btnACancel;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chInfo;
        private System.Windows.Forms.Label lblAEmail;
        private System.Windows.Forms.TextBox txtbAEmail;
        private System.Windows.Forms.Label lblAPesq;
        private System.Windows.Forms.TextBox txtbAPesq;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblACpf;
        private System.Windows.Forms.TextBox txtbACpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLupaAgen;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox txtbValor;
    }
}