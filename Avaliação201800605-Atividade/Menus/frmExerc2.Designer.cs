namespace Menus
{
    partial class frmExerc2
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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDiv10 = new System.Windows.Forms.Label();
            this.lblDiv5 = new System.Windows.Forms.Label();
            this.lblDiv2 = new System.Windows.Forms.Label();
            this.lblNaoDiv = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInformar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre com um número e será informado se ele é divisível por 10, por 5, por 2 ou s" +
                "e não é divisível por nenhum destes.";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(95, 61);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(92, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Digite um número:";
            // 
            // lblDiv10
            // 
            this.lblDiv10.AutoSize = true;
            this.lblDiv10.Location = new System.Drawing.Point(12, 141);
            this.lblDiv10.Name = "lblDiv10";
            this.lblDiv10.Size = new System.Drawing.Size(0, 13);
            this.lblDiv10.TabIndex = 1;
            // 
            // lblDiv5
            // 
            this.lblDiv5.AutoSize = true;
            this.lblDiv5.Location = new System.Drawing.Point(12, 167);
            this.lblDiv5.Name = "lblDiv5";
            this.lblDiv5.Size = new System.Drawing.Size(0, 13);
            this.lblDiv5.TabIndex = 2;
            // 
            // lblDiv2
            // 
            this.lblDiv2.AutoSize = true;
            this.lblDiv2.Location = new System.Drawing.Point(12, 193);
            this.lblDiv2.Name = "lblDiv2";
            this.lblDiv2.Size = new System.Drawing.Size(0, 13);
            this.lblDiv2.TabIndex = 3;
            // 
            // lblNaoDiv
            // 
            this.lblNaoDiv.AutoSize = true;
            this.lblNaoDiv.Location = new System.Drawing.Point(12, 220);
            this.lblNaoDiv.Name = "lblNaoDiv";
            this.lblNaoDiv.Size = new System.Drawing.Size(0, 13);
            this.lblNaoDiv.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(98, 77);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnInformar
            // 
            this.btnInformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformar.Location = new System.Drawing.Point(102, 103);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(75, 23);
            this.btnInformar.TabIndex = 6;
            this.btnInformar.Text = "Informar";
            this.btnInformar.UseVisualStyleBackColor = true;
            this.btnInformar.Click += new System.EventHandler(this.btnInformar_Click);
            // 
            // frmExerc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDiv10);
            this.Controls.Add(this.lblDiv5);
            this.Controls.Add(this.lblDiv2);
            this.Controls.Add(this.lblNaoDiv);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnInformar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExerc2";
            this.Text = "Exercício 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExerc2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDiv10;
        private System.Windows.Forms.Label lblDiv5;
        private System.Windows.Forms.Label lblDiv2;
        private System.Windows.Forms.Label lblNaoDiv;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInformar;
    }
}