namespace MaiorDeTres
{
    partial class frmMaiorValorDeTres
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txbValorA = new System.Windows.Forms.TextBox();
            this.txbValorB = new System.Windows.Forms.TextBox();
            this.txbValorC = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(12, 50);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(41, 13);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A";
            this.lblValorA.Click += new System.EventHandler(this.lblValorA_Click);
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(12, 84);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(41, 13);
            this.lblValorB.TabIndex = 1;
            this.lblValorB.Text = "Valor B";
            this.lblValorB.Click += new System.EventHandler(this.lblValorB_Click);
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(12, 117);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(41, 13);
            this.lblValorC.TabIndex = 2;
            this.lblValorC.Text = "Valor C";
            this.lblValorC.Click += new System.EventHandler(this.lblValorC_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(94, 224);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Click += new System.EventHandler(this.lblResposta_Click);
            // 
            // txbValorA
            // 
            this.txbValorA.Location = new System.Drawing.Point(53, 43);
            this.txbValorA.Name = "txbValorA";
            this.txbValorA.Size = new System.Drawing.Size(100, 20);
            this.txbValorA.TabIndex = 4;
            this.txbValorA.TextChanged += new System.EventHandler(this.txbValorA_TextChanged);
            // 
            // txbValorB
            // 
            this.txbValorB.Location = new System.Drawing.Point(53, 77);
            this.txbValorB.Name = "txbValorB";
            this.txbValorB.Size = new System.Drawing.Size(100, 20);
            this.txbValorB.TabIndex = 5;
            this.txbValorB.TextChanged += new System.EventHandler(this.txbValorB_TextChanged);
            // 
            // txbValorC
            // 
            this.txbValorC.Location = new System.Drawing.Point(53, 110);
            this.txbValorC.Name = "txbValorC";
            this.txbValorC.Size = new System.Drawing.Size(100, 20);
            this.txbValorC.TabIndex = 6;
            this.txbValorC.TextChanged += new System.EventHandler(this.txbValorC_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(97, 178);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmMaiorValorDeTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbValorC);
            this.Controls.Add(this.txbValorB);
            this.Controls.Add(this.txbValorA);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Name = "frmMaiorValorDeTres";
            this.Text = "Maior Valor";
            this.Load += new System.EventHandler(this.frmMaiorValorDeTres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txbValorA;
        private System.Windows.Forms.TextBox txbValorB;
        private System.Windows.Forms.TextBox txbValorC;
        private System.Windows.Forms.Button btnVerificar;
    }
}

