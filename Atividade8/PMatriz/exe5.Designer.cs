namespace PMatriz
{
    partial class exe5
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
            this.btnExeList5 = new System.Windows.Forms.Button();
            this.listBoxAlunos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExeList5
            // 
            this.btnExeList5.Location = new System.Drawing.Point(118, 146);
            this.btnExeList5.Name = "btnExeList5";
            this.btnExeList5.Size = new System.Drawing.Size(118, 100);
            this.btnExeList5.TabIndex = 0;
            this.btnExeList5.Text = "Executar";
            this.btnExeList5.UseVisualStyleBackColor = true;
            this.btnExeList5.Click += new System.EventHandler(this.btnExeList5_Click);
            // 
            // listBoxAlunos
            // 
            this.listBoxAlunos.FormattingEnabled = true;
            this.listBoxAlunos.ItemHeight = 20;
            this.listBoxAlunos.Location = new System.Drawing.Point(352, 24);
            this.listBoxAlunos.Name = "listBoxAlunos";
            this.listBoxAlunos.Size = new System.Drawing.Size(436, 404);
            this.listBoxAlunos.TabIndex = 1;
            // 
            // exe5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAlunos);
            this.Controls.Add(this.btnExeList5);
            this.Name = "exe5";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExeList5;
        private System.Windows.Forms.ListBox listBoxAlunos;
    }
}