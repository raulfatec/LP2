namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRaio = new TextBox();
            lblAltura = new Label();
            btnCalcular = new Button();
            lblRaio = new Label();
            lblResultado = new Label();
            txtResultado = new TextBox();
            txtAltura = new TextBox();
            btnSair = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(232, 96);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(150, 31);
            txtRaio.TabIndex = 0;
            txtRaio.Validated += txtRaio_Validated;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Enabled = false;
            lblAltura.Location = new Point(97, 178);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(59, 25);
            lblAltura.TabIndex = 11;
            lblAltura.Text = "Altura";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(232, 348);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Enabled = false;
            lblRaio.Location = new Point(97, 96);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(47, 25);
            lblRaio.TabIndex = 10;
            lblRaio.Text = "Raio";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Enabled = false;
            lblResultado.Location = new Point(97, 258);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(232, 258);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(232, 178);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 2;
            txtAltura.Validating += txtAltura_Validating;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(394, 348);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 34);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(558, 348);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(txtAltura);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(lblRaio);
            Controls.Add(btnCalcular);
            Controls.Add(lblAltura);
            Controls.Add(txtRaio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private Label lblAltura;
        private Button btnCalcular;
        private Label lblRaio;
        private Label lblResultado;
        private TextBox txtResultado;
        private TextBox txtAltura;
        private Button btnSair;
        private Button btnLimpar;
    }
}
