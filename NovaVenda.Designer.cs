namespace TattoSystemManager
{
    partial class NovaVenda
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Valor(R$)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.lstvwVenda = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.btnGRel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNTela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvwVenda
            // 
            this.lstvwVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chValor});
            this.lstvwVenda.GridLines = true;
            this.lstvwVenda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvwVenda.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstvwVenda.Location = new System.Drawing.Point(12, 98);
            this.lstvwVenda.Name = "lstvwVenda";
            this.lstvwVenda.Size = new System.Drawing.Size(297, 270);
            this.lstvwVenda.TabIndex = 0;
            this.lstvwVenda.UseCompatibleStateImageBehavior = false;
            this.lstvwVenda.View = System.Windows.Forms.View.Details;
            this.lstvwVenda.SelectedIndexChanged += new System.EventHandler(this.lstvwVenda_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 58;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNome.Width = 140;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor(R$)";
            this.chValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chValor.Width = 92;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(315, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Location = new System.Drawing.Point(402, 348);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.ReadOnly = true;
            this.txtbTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbTotal.TabIndex = 2;
            // 
            // btnGRel
            // 
            this.btnGRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRel.Image = ((System.Drawing.Image)(resources.GetObject("btnGRel.Image")));
            this.btnGRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGRel.Location = new System.Drawing.Point(340, 145);
            this.btnGRel.Name = "btnGRel";
            this.btnGRel.Size = new System.Drawing.Size(124, 46);
            this.btnGRel.TabIndex = 3;
            this.btnGRel.Text = "Gerar Relatório";
            this.btnGRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGRel.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(352, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNTela
            // 
            this.lblNTela.AutoSize = true;
            this.lblNTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTela.Location = new System.Drawing.Point(47, 26);
            this.lblNTela.Name = "lblNTela";
            this.lblNTela.Size = new System.Drawing.Size(151, 16);
            this.lblNTela.TabIndex = 5;
            this.lblNTela.Text = "Relatório de Vendas";
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(511, 376);
            this.Controls.Add(this.lblNTela);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGRel);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstvwVenda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo System Manager";
            this.Load += new System.EventHandler(this.NovaVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chValor;
        private System.Windows.Forms.Button btnGRel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNTela;

    }
}