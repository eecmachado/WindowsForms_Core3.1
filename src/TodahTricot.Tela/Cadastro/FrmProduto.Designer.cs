namespace TodahTricot.Tela.Cadastro
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnGravar = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnFechar = new System.Windows.Forms.Button();
            this.txtBxDescricao = new System.Windows.Forms.TextBox();
            this.bttnPesquisar = new System.Windows.Forms.Button();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pctrBxProduto = new System.Windows.Forms.PictureBox();
            this.bttnImagem = new System.Windows.Forms.Button();
            this.pnFlDlgFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 77);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bttnGravar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnLimpar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnExcluir, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttnGravar
            // 
            this.bttnGravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnGravar.FlatAppearance.BorderSize = 0;
            this.bttnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGravar.Location = new System.Drawing.Point(50, 20);
            this.bttnGravar.Margin = new System.Windows.Forms.Padding(50, 20, 25, 10);
            this.bttnGravar.Name = "bttnGravar";
            this.bttnGravar.Size = new System.Drawing.Size(109, 47);
            this.bttnGravar.TabIndex = 0;
            this.bttnGravar.Text = "Gravar";
            this.bttnGravar.UseVisualStyleBackColor = true;
            this.bttnGravar.Click += new System.EventHandler(this.bttnGravar_Click);
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnLimpar.FlatAppearance.BorderSize = 0;
            this.bttnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLimpar.Location = new System.Drawing.Point(209, 20);
            this.bttnLimpar.Margin = new System.Windows.Forms.Padding(25, 20, 25, 10);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(134, 47);
            this.bttnLimpar.TabIndex = 1;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // bttnExcluir
            // 
            this.bttnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnExcluir.FlatAppearance.BorderSize = 0;
            this.bttnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExcluir.Location = new System.Drawing.Point(393, 20);
            this.bttnExcluir.Margin = new System.Windows.Forms.Padding(25, 20, 50, 10);
            this.bttnExcluir.Name = "bttnExcluir";
            this.bttnExcluir.Size = new System.Drawing.Size(110, 47);
            this.bttnExcluir.TabIndex = 2;
            this.bttnExcluir.Text = "Excluir";
            this.bttnExcluir.UseVisualStyleBackColor = true;
            this.bttnExcluir.Click += new System.EventHandler(this.bttnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo";
            // 
            // bttnFechar
            // 
            this.bttnFechar.FlatAppearance.BorderSize = 0;
            this.bttnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnFechar.Location = new System.Drawing.Point(510, 0);
            this.bttnFechar.Name = "bttnFechar";
            this.bttnFechar.Size = new System.Drawing.Size(43, 33);
            this.bttnFechar.TabIndex = 3;
            this.bttnFechar.TabStop = false;
            this.bttnFechar.Text = "X";
            this.bttnFechar.UseVisualStyleBackColor = true;
            this.bttnFechar.Click += new System.EventHandler(this.bttnFechar_Click);
            // 
            // txtBxDescricao
            // 
            this.txtBxDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxDescricao.Location = new System.Drawing.Point(187, 56);
            this.txtBxDescricao.MaxLength = 50;
            this.txtBxDescricao.Name = "txtBxDescricao";
            this.txtBxDescricao.Size = new System.Drawing.Size(351, 16);
            this.txtBxDescricao.TabIndex = 1;
            this.txtBxDescricao.TextChanged += new System.EventHandler(this.txtBxDescricao_Validated);
            this.txtBxDescricao.Validated += new System.EventHandler(this.txtBxDescricao_Validated);
            // 
            // bttnPesquisar
            // 
            this.bttnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnPesquisar.BackgroundImage")));
            this.bttnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnPesquisar.FlatAppearance.BorderSize = 0;
            this.bttnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPesquisar.Location = new System.Drawing.Point(120, 56);
            this.bttnPesquisar.Name = "bttnPesquisar";
            this.bttnPesquisar.Size = new System.Drawing.Size(28, 16);
            this.bttnPesquisar.TabIndex = 1;
            this.bttnPesquisar.TabStop = false;
            this.bttnPesquisar.UseVisualStyleBackColor = true;
            this.bttnPesquisar.Click += new System.EventHandler(this.bttnPesquisar_Click);
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxCodigo.Location = new System.Drawing.Point(12, 56);
            this.txtBxCodigo.MaxLength = 6;
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(102, 16);
            this.txtBxCodigo.TabIndex = 0;
            this.txtBxCodigo.TextChanged += new System.EventHandler(this.txtBxCodigo_TextChanged);
            this.txtBxCodigo.Validated += new System.EventHandler(this.txtBxCodigo_Validated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pctrBxProduto);
            this.panel2.Controls.Add(this.bttnImagem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bttnFechar);
            this.panel2.Controls.Add(this.txtBxDescricao);
            this.panel2.Controls.Add(this.bttnPesquisar);
            this.panel2.Controls.Add(this.txtBxCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 280);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Produto";
            // 
            // pctrBxProduto
            // 
            this.pctrBxProduto.Location = new System.Drawing.Point(11, 78);
            this.pctrBxProduto.Name = "pctrBxProduto";
            this.pctrBxProduto.Size = new System.Drawing.Size(527, 199);
            this.pctrBxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxProduto.TabIndex = 9;
            this.pctrBxProduto.TabStop = false;
            // 
            // bttnImagem
            // 
            this.bttnImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnImagem.BackgroundImage")));
            this.bttnImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnImagem.FlatAppearance.BorderSize = 0;
            this.bttnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnImagem.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnImagem.Location = new System.Drawing.Point(154, 55);
            this.bttnImagem.Name = "bttnImagem";
            this.bttnImagem.Size = new System.Drawing.Size(27, 17);
            this.bttnImagem.TabIndex = 6;
            this.bttnImagem.UseVisualStyleBackColor = true;
            this.bttnImagem.Click += new System.EventHandler(this.bttnImagem_Click);
            // 
            // pnFlDlgFoto
            // 
            this.pnFlDlgFoto.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(553, 357);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProduto";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnFechar;
        private System.Windows.Forms.TextBox txtBxDescricao;
        private System.Windows.Forms.Button bttnPesquisar;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnGravar;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnExcluir;
        private System.Windows.Forms.OpenFileDialog pnFlDlgFoto;
        private System.Windows.Forms.Button bttnImagem;
        private System.Windows.Forms.PictureBox pctrBxProduto;
        private System.Windows.Forms.Label label4;
    }
}