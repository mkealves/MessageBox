namespace messagebox
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSNome = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSNome
            // 
            this.lblSNome.AutoSize = true;
            this.lblSNome.Location = new System.Drawing.Point(13, 45);
            this.lblSNome.Name = "lblSNome";
            this.lblSNome.Size = new System.Drawing.Size(61, 13);
            this.lblSNome.TabIndex = 1;
            this.lblSNome.Text = "Sobrenome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(16, 79);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(16, 116);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(218, 111);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(80, 13);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(258, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbSNome
            // 
            this.txbSNome.Location = new System.Drawing.Point(80, 45);
            this.txbSNome.Name = "txbSNome";
            this.txbSNome.Size = new System.Drawing.Size(258, 20);
            this.txbSNome.TabIndex = 6;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(80, 79);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(37, 20);
            this.txbIdade.TabIndex = 7;
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(80, 116);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(100, 20);
            this.txbSalario.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbSNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblSNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Aumento de Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSNome;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbSalario;
    }
}

