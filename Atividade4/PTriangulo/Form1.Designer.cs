namespace PTriangulo
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
            this.components = new System.ComponentModel.Container();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(190, 97);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 0;
            this.txtA.Validating += new System.ComponentModel.CancelEventHandler(this.txtA_Validating);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(190, 159);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 1;
            this.txtB.Validating += new System.ComponentModel.CancelEventHandler(this.txtB_Validating);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(190, 221);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 2;
            this.txtC.Validating += new System.ComponentModel.CancelEventHandler(this.txtC_Validating);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(36, 97);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(83, 20);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Valor de A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(36, 159);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(83, 20);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Valor de B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(36, 227);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(83, 20);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Valor de C";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(67, 344);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(113, 37);
            this.btnExec.TabIndex = 6;
            this.btnExec.Text = "Executa";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(191, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 37);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnLimpar.Location = new System.Drawing.Point(319, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 37);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnLimpar;
    }
}

