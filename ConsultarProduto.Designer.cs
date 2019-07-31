namespace TattoSystemManager
{
    partial class ConsultarProduto
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Valor");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Marca");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Descrição");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProduto));
            this.lstvwConProd = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNomeProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarcaProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbPesqProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtbNomeProd = new System.Windows.Forms.TextBox();
            this.lblValorProd = new System.Windows.Forms.Label();
            this.txtbValorProd = new System.Windows.Forms.TextBox();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.txtbMarcaProd = new System.Windows.Forms.TextBox();
            this.lblDescriProd = new System.Windows.Forms.Label();
            this.txtbDescriProd = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirCProd = new System.Windows.Forms.Button();
            this.btnLimpCProd = new System.Windows.Forms.Button();
            this.lblNTelaConP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPesq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvwConProd
            // 
            this.lstvwConProd.AllowColumnReorder = true;
            this.lstvwConProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNomeProd,
            this.chValorProd,
            this.chMarcaProd,
            this.chDescriProd});
            this.lstvwConProd.FullRowSelect = true;
            this.lstvwConProd.GridLines = true;
            this.lstvwConProd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstvwConProd.Location = new System.Drawing.Point(12, 84);
            this.lstvwConProd.Name = "lstvwConProd";
            this.lstvwConProd.Size = new System.Drawing.Size(624, 306);
            this.lstvwConProd.TabIndex = 2;
            this.lstvwConProd.UseCompatibleStateImageBehavior = false;
            this.lstvwConProd.View = System.Windows.Forms.View.Details;
            this.lstvwConProd.SelectedIndexChanged += new System.EventHandler(this.lstvwConProd_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 25;
            // 
            // chNomeProd
            // 
            this.chNomeProd.Text = "Nome";
            this.chNomeProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNomeProd.Width = 121;
            // 
            // chValorProd
            // 
            this.chValorProd.Text = "Valor";
            this.chValorProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chValorProd.Width = 79;
            // 
            // chMarcaProd
            // 
            this.chMarcaProd.Text = "Marca";
            this.chMarcaProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMarcaProd.Width = 129;
            // 
            // chDescriProd
            // 
            this.chDescriProd.Text = "Descrição";
            this.chDescriProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDescriProd.Width = 266;
            // 
            // txtbPesqProd
            // 
            this.txtbPesqProd.Location = new System.Drawing.Point(464, 36);
            this.txtbPesqProd.Name = "txtbPesqProd";
            this.txtbPesqProd.Size = new System.Drawing.Size(113, 20);
            this.txtbPesqProd.TabIndex = 4;
            this.txtbPesqProd.TextChanged += new System.EventHandler(this.txtbPesqProd_TextChanged);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(651, 84);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(70, 25);
            this.lblNomeProd.TabIndex = 5;
            this.lblNomeProd.Text = "Nome:";
            // 
            // txtbNomeProd
            // 
            this.txtbNomeProd.Location = new System.Drawing.Point(733, 84);
            this.txtbNomeProd.Name = "txtbNomeProd";
            this.txtbNomeProd.Size = new System.Drawing.Size(125, 20);
            this.txtbNomeProd.TabIndex = 6;
            // 
            // lblValorProd
            // 
            this.lblValorProd.AutoSize = true;
            this.lblValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProd.Location = new System.Drawing.Point(651, 136);
            this.lblValorProd.Name = "lblValorProd";
            this.lblValorProd.Size = new System.Drawing.Size(102, 25);
            this.lblValorProd.TabIndex = 7;
            this.lblValorProd.Text = "Valor(R$):";
            // 
            // txtbValorProd
            // 
            this.txtbValorProd.Location = new System.Drawing.Point(748, 141);
            this.txtbValorProd.Name = "txtbValorProd";
            this.txtbValorProd.Size = new System.Drawing.Size(85, 20);
            this.txtbValorProd.TabIndex = 8;
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProd.Location = new System.Drawing.Point(651, 192);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(73, 25);
            this.lblMarcaProd.TabIndex = 9;
            this.lblMarcaProd.Text = "Marca:";
            // 
            // txtbMarcaProd
            // 
            this.txtbMarcaProd.Location = new System.Drawing.Point(733, 197);
            this.txtbMarcaProd.Name = "txtbMarcaProd";
            this.txtbMarcaProd.Size = new System.Drawing.Size(100, 20);
            this.txtbMarcaProd.TabIndex = 10;
            // 
            // lblDescriProd
            // 
            this.lblDescriProd.AutoSize = true;
            this.lblDescriProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriProd.Location = new System.Drawing.Point(728, 235);
            this.lblDescriProd.Name = "lblDescriProd";
            this.lblDescriProd.Size = new System.Drawing.Size(105, 25);
            this.lblDescriProd.TabIndex = 11;
            this.lblDescriProd.Text = "Descrição:";
            // 
            // txtbDescriProd
            // 
            this.txtbDescriProd.Location = new System.Drawing.Point(656, 263);
            this.txtbDescriProd.Multiline = true;
            this.txtbDescriProd.Name = "txtbDescriProd";
            this.txtbDescriProd.Size = new System.Drawing.Size(253, 79);
            this.txtbDescriProd.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(656, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 42);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(864, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirCProd
            // 
            this.btnExcluirCProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCProd.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCProd.Image")));
            this.btnExcluirCProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCProd.Location = new System.Drawing.Point(758, 348);
            this.btnExcluirCProd.Name = "btnExcluirCProd";
            this.btnExcluirCProd.Size = new System.Drawing.Size(86, 42);
            this.btnExcluirCProd.TabIndex = 15;
            this.btnExcluirCProd.Text = "Deletar";
            this.btnExcluirCProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCProd.UseVisualStyleBackColor = true;
            this.btnExcluirCProd.Click += new System.EventHandler(this.btnExcluirCProd_Click);
            // 
            // btnLimpCProd
            // 
            this.btnLimpCProd.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpCProd.Image")));
            this.btnLimpCProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpCProd.Location = new System.Drawing.Point(864, 136);
            this.btnLimpCProd.Name = "btnLimpCProd";
            this.btnLimpCProd.Size = new System.Drawing.Size(45, 36);
            this.btnLimpCProd.TabIndex = 16;
            this.btnLimpCProd.UseVisualStyleBackColor = true;
            this.btnLimpCProd.Click += new System.EventHandler(this.btnLimpCProd_Click);
            // 
            // lblNTelaConP
            // 
            this.lblNTelaConP.AutoSize = true;
            this.lblNTelaConP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTelaConP.Location = new System.Drawing.Point(66, 26);
            this.lblNTelaConP.Name = "lblNTelaConP";
            this.lblNTelaConP.Size = new System.Drawing.Size(254, 16);
            this.lblNTelaConP.TabIndex = 17;
            this.lblNTelaConP.Text = "Consultar/Alterar Dados do Produto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.Location = new System.Drawing.Point(360, 36);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(98, 24);
            this.lblPesq.TabIndex = 19;
            this.lblPesq.Text = "Pesquisar:";
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(989, 396);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNTelaConP);
            this.Controls.Add(this.btnLimpCProd);
            this.Controls.Add(this.btnExcluirCProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtbDescriProd);
            this.Controls.Add(this.lblDescriProd);
            this.Controls.Add(this.txtbMarcaProd);
            this.Controls.Add(this.lblMarcaProd);
            this.Controls.Add(this.txtbValorProd);
            this.Controls.Add(this.lblValorProd);
            this.Controls.Add(this.txtbNomeProd);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.txtbPesqProd);
            this.Controls.Add(this.lstvwConProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.Load += new System.EventHandler(this.ConsultarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwConProd;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNomeProd;
        private System.Windows.Forms.ColumnHeader chValorProd;
        private System.Windows.Forms.ColumnHeader chMarcaProd;
        private System.Windows.Forms.ColumnHeader chDescriProd;
        private System.Windows.Forms.TextBox txtbPesqProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.TextBox txtbNomeProd;
        private System.Windows.Forms.Label lblValorProd;
        private System.Windows.Forms.TextBox txtbValorProd;
        private System.Windows.Forms.Label lblMarcaProd;
        private System.Windows.Forms.TextBox txtbMarcaProd;
        private System.Windows.Forms.Label lblDescriProd;
        private System.Windows.Forms.TextBox txtbDescriProd;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluirCProd;
        private System.Windows.Forms.Button btnLimpCProd;
        private System.Windows.Forms.Label lblNTelaConP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPesq;
    }
}