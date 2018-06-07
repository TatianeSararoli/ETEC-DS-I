namespace Menus
{
    partial class frmExerc4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblMesCorr = new System.Windows.Forms.Label();
            this.btnMes = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ler um número inteiro entre 1 e 12 e escrever o mês correspondente. Caso o número" +
                " seja fora desse intervalo, será informado que não existe mês com este número.";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(66, 100);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(144, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Digite o número do mês:";
            // 
            // lblMesCorr
            // 
            this.lblMesCorr.AutoSize = true;
            this.lblMesCorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesCorr.Location = new System.Drawing.Point(93, 188);
            this.lblMesCorr.Name = "lblMesCorr";
            this.lblMesCorr.Size = new System.Drawing.Size(0, 13);
            this.lblMesCorr.TabIndex = 2;
            // 
            // btnMes
            // 
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Location = new System.Drawing.Point(12, 170);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 48);
            this.btnMes.TabIndex = 3;
            this.btnMes.Text = "Mês";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(94, 126);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(75, 20);
            this.txtMes.TabIndex = 4;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            // 
            // frmExerc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.lblMesCorr);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExerc4";
            this.Text = "Exercício 4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExerc4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblMesCorr;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.TextBox txtMes;
    }
}