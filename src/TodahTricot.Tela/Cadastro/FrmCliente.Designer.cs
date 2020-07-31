namespace TodahTricot.Tela.Cadastro
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnGravar = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnFechar = new System.Windows.Forms.Button();
            this.txtBxNome = new System.Windows.Forms.TextBox();
            this.bttnPesquisar = new System.Windows.Forms.Button();
            this.txtBxDocumento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBxUF = new System.Windows.Forms.ListBox();
            this.txtBxMunicipio = new System.Windows.Forms.TextBox();
            this.txtBxComplemento = new System.Windows.Forms.TextBox();
            this.txtBxNumero = new System.Windows.Forms.TextBox();
            this.txtBxEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxCep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
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
            this.label2.Location = new System.Drawing.Point(154, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
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
            // txtBxNome
            // 
            this.txtBxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxNome.Location = new System.Drawing.Point(154, 56);
            this.txtBxNome.MaxLength = 50;
            this.txtBxNome.Name = "txtBxNome";
            this.txtBxNome.Size = new System.Drawing.Size(387, 16);
            this.txtBxNome.TabIndex = 1;
            this.txtBxNome.TextChanged += new System.EventHandler(this.txtBxNome_Validated);
            this.txtBxNome.Validated += new System.EventHandler(this.txtBxNome_Validated);
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
            // txtBxDocumento
            // 
            this.txtBxDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxDocumento.Location = new System.Drawing.Point(12, 56);
            this.txtBxDocumento.MaxLength = 14;
            this.txtBxDocumento.Name = "txtBxDocumento";
            this.txtBxDocumento.Size = new System.Drawing.Size(102, 16);
            this.txtBxDocumento.TabIndex = 0;
            this.txtBxDocumento.TextChanged += new System.EventHandler(this.txtBxDocumento_TextChanged);
            this.txtBxDocumento.Validated += new System.EventHandler(this.txtBxDocumento_Validated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBxUF);
            this.panel2.Controls.Add(this.txtBxMunicipio);
            this.panel2.Controls.Add(this.txtBxComplemento);
            this.panel2.Controls.Add(this.txtBxNumero);
            this.panel2.Controls.Add(this.txtBxEndereco);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBxCep);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBxEmail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bttnFechar);
            this.panel2.Controls.Add(this.txtBxNome);
            this.panel2.Controls.Add(this.bttnPesquisar);
            this.panel2.Controls.Add(this.txtBxDocumento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 271);
            this.panel2.TabIndex = 0;
            // 
            // lstBxUF
            // 
            this.lstBxUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.lstBxUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.lstBxUF.FormattingEnabled = true;
            this.lstBxUF.ItemHeight = 15;
            this.lstBxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.lstBxUF.Location = new System.Drawing.Point(290, 244);
            this.lstBxUF.Name = "lstBxUF";
            this.lstBxUF.Size = new System.Drawing.Size(43, 15);
            this.lstBxUF.Sorted = true;
            this.lstBxUF.TabIndex = 25;
            // 
            // txtBxMunicipio
            // 
            this.txtBxMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxMunicipio.Location = new System.Drawing.Point(12, 244);
            this.txtBxMunicipio.Name = "txtBxMunicipio";
            this.txtBxMunicipio.Size = new System.Drawing.Size(272, 16);
            this.txtBxMunicipio.TabIndex = 23;
            // 
            // txtBxComplemento
            // 
            this.txtBxComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxComplemento.Location = new System.Drawing.Point(113, 197);
            this.txtBxComplemento.Name = "txtBxComplemento";
            this.txtBxComplemento.Size = new System.Drawing.Size(427, 16);
            this.txtBxComplemento.TabIndex = 22;
            // 
            // txtBxNumero
            // 
            this.txtBxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxNumero.Location = new System.Drawing.Point(12, 197);
            this.txtBxNumero.Name = "txtBxNumero";
            this.txtBxNumero.Size = new System.Drawing.Size(95, 16);
            this.txtBxNumero.TabIndex = 21;
            // 
            // txtBxEndereco
            // 
            this.txtBxEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxEndereco.Location = new System.Drawing.Point(113, 150);
            this.txtBxEndereco.Name = "txtBxEndereco";
            this.txtBxEndereco.Size = new System.Drawing.Size(428, 16);
            this.txtBxEndereco.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "UF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Município";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número";
            // 
            // txtBxCep
            // 
            this.txtBxCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxCep.Location = new System.Drawing.Point(12, 150);
            this.txtBxCep.Name = "txtBxCep";
            this.txtBxCep.Size = new System.Drawing.Size(95, 16);
            this.txtBxCep.TabIndex = 14;
            this.txtBxCep.TextChanged += new System.EventHandler(this.txtBxCep_TextChanged);
            this.txtBxCep.Validated += new System.EventHandler(this.txtBxCep_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cep";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(79)))));
            this.txtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.txtBxEmail.Location = new System.Drawing.Point(12, 103);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(529, 16);
            this.txtBxEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(553, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProduto";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnFechar;
        private System.Windows.Forms.TextBox txtBxNome;
        private System.Windows.Forms.Button bttnPesquisar;
        private System.Windows.Forms.TextBox txtBxDocumento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnGravar;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxCep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxMunicipio;
        private System.Windows.Forms.TextBox txtBxComplemento;
        private System.Windows.Forms.TextBox txtBxNumero;
        private System.Windows.Forms.TextBox txtBxEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstBxUF;
    }
}