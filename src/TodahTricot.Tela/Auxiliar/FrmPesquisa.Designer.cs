namespace TodahTricot.Tela.Auxiliar
{
    partial class FrmPesquisa
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
            this.bttnFechar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttnFechar
            // 
            this.bttnFechar.FlatAppearance.BorderSize = 0;
            this.bttnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnFechar.Location = new System.Drawing.Point(545, -1);
            this.bttnFechar.Name = "bttnFechar";
            this.bttnFechar.Size = new System.Drawing.Size(43, 33);
            this.bttnFechar.TabIndex = 3;
            this.bttnFechar.TabStop = false;
            this.bttnFechar.Text = "X";
            this.bttnFechar.UseVisualStyleBackColor = true;
            this.bttnFechar.Click += new System.EventHandler(this.bttnFechar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(566, 360);
            this.listBox1.TabIndex = 4;
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(590, 421);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttnFechar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnFechar;
        private System.Windows.Forms.ListBox listBox1;
    }
}