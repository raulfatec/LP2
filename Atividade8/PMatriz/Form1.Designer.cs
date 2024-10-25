namespace PMatriz
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
            this.btnExe1 = new System.Windows.Forms.Button();
            this.btnExe2 = new System.Windows.Forms.Button();
            this.btnExe3 = new System.Windows.Forms.Button();
            this.btnExe4 = new System.Windows.Forms.Button();
            this.btnExe5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExe1
            // 
            this.btnExe1.Location = new System.Drawing.Point(95, 71);
            this.btnExe1.Name = "btnExe1";
            this.btnExe1.Size = new System.Drawing.Size(128, 76);
            this.btnExe1.TabIndex = 0;
            this.btnExe1.Text = "Exercicio 1";
            this.btnExe1.UseVisualStyleBackColor = true;
            this.btnExe1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExe2
            // 
            this.btnExe2.Location = new System.Drawing.Point(95, 193);
            this.btnExe2.Name = "btnExe2";
            this.btnExe2.Size = new System.Drawing.Size(128, 76);
            this.btnExe2.TabIndex = 1;
            this.btnExe2.Text = "Exercicio 2";
            this.btnExe2.UseVisualStyleBackColor = true;
            this.btnExe2.Click += new System.EventHandler(this.btnExe2_Click);
            // 
            // btnExe3
            // 
            this.btnExe3.Location = new System.Drawing.Point(537, 71);
            this.btnExe3.Name = "btnExe3";
            this.btnExe3.Size = new System.Drawing.Size(128, 76);
            this.btnExe3.TabIndex = 2;
            this.btnExe3.Text = "Exercicio 3";
            this.btnExe3.UseVisualStyleBackColor = true;
            this.btnExe3.Click += new System.EventHandler(this.btnExe3_Click);
            // 
            // btnExe4
            // 
            this.btnExe4.Location = new System.Drawing.Point(537, 193);
            this.btnExe4.Name = "btnExe4";
            this.btnExe4.Size = new System.Drawing.Size(128, 76);
            this.btnExe4.TabIndex = 3;
            this.btnExe4.Text = "Exercicio 4";
            this.btnExe4.UseVisualStyleBackColor = true;
            this.btnExe4.Click += new System.EventHandler(this.btnExe4_Click);
            // 
            // btnExe5
            // 
            this.btnExe5.Location = new System.Drawing.Point(310, 285);
            this.btnExe5.Name = "btnExe5";
            this.btnExe5.Size = new System.Drawing.Size(128, 76);
            this.btnExe5.TabIndex = 4;
            this.btnExe5.Text = "Exercicio 5";
            this.btnExe5.UseVisualStyleBackColor = true;
            this.btnExe5.Click += new System.EventHandler(this.btnExe5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExe5);
            this.Controls.Add(this.btnExe4);
            this.Controls.Add(this.btnExe3);
            this.Controls.Add(this.btnExe2);
            this.Controls.Add(this.btnExe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExe1;
        private System.Windows.Forms.Button btnExe2;
        private System.Windows.Forms.Button btnExe3;
        private System.Windows.Forms.Button btnExe4;
        private System.Windows.Forms.Button btnExe5;
    }
}

