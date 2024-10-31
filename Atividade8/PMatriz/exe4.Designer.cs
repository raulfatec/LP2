namespace PMatriz
{
    partial class exe4
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
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.ItemHeight = 20;
            this.listBoxNomes.Location = new System.Drawing.Point(343, 80);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(418, 344);
            this.listBoxNomes.TabIndex = 0;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(92, 145);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(99, 84);
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "Executar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.button1_Click);
            // 
            // exe4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.listBoxNomes);
            this.Name = "exe4";
            this.Text = "exe4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.Button btnExe;
    }
}