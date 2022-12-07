namespace ex2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao2 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Yellow;
            this.botao2.Location = new System.Drawing.Point(289, 55);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(152, 72);
            this.botao2.TabIndex = 0;
            this.botao2.Text = "amerelo";
            this.botao2.UseVisualStyleBackColor = false;
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Red;
            this.botao1.Location = new System.Drawing.Point(51, 55);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(152, 72);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "vermelho";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pimenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label label1;
    }
}

