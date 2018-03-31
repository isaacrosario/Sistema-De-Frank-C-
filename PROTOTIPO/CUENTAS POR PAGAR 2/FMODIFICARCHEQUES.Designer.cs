namespace CUENTAS_POR_PAGAR_2
{
    partial class FMODIFICARCHEQUES
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
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TFECHACHEQ = new System.Windows.Forms.TextBox();
            this.TVALCHEQ = new System.Windows.Forms.TextBox();
            this.TNUMCHEQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BACTUALIZAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(158, 51);
            this.TNUMFACT.Margin = new System.Windows.Forms.Padding(2);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(156, 20);
            this.TNUMFACT.TabIndex = 52;
            this.TNUMFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMFACT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // TFECHACHEQ
            // 
            this.TFECHACHEQ.Location = new System.Drawing.Point(158, 150);
            this.TFECHACHEQ.Margin = new System.Windows.Forms.Padding(2);
            this.TFECHACHEQ.Name = "TFECHACHEQ";
            this.TFECHACHEQ.Size = new System.Drawing.Size(156, 20);
            this.TFECHACHEQ.TabIndex = 49;
            this.TFECHACHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHACHEQ_KeyPress);
            // 
            // TVALCHEQ
            // 
            this.TVALCHEQ.Location = new System.Drawing.Point(158, 124);
            this.TVALCHEQ.Margin = new System.Windows.Forms.Padding(2);
            this.TVALCHEQ.Name = "TVALCHEQ";
            this.TVALCHEQ.Size = new System.Drawing.Size(156, 20);
            this.TVALCHEQ.TabIndex = 48;
            this.TVALCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVALCHEQ_KeyPress);
            // 
            // TNUMCHEQ
            // 
            this.TNUMCHEQ.Location = new System.Drawing.Point(158, 90);
            this.TNUMCHEQ.Margin = new System.Windows.Forms.Padding(2);
            this.TNUMCHEQ.Name = "TNUMCHEQ";
            this.TNUMCHEQ.Size = new System.Drawing.Size(105, 20);
            this.TNUMCHEQ.TabIndex = 47;
            this.TNUMCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMCHEQ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "FECHA CHEQUE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "VALOR CHEQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "NUMERO CHEQUE";
            // 
            // BACTUALIZAR
            // 
            this.BACTUALIZAR.Location = new System.Drawing.Point(141, 224);
            this.BACTUALIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.BACTUALIZAR.Name = "BACTUALIZAR";
            this.BACTUALIZAR.Size = new System.Drawing.Size(89, 25);
            this.BACTUALIZAR.TabIndex = 50;
            this.BACTUALIZAR.Text = "ACTUALIZAR";
            this.BACTUALIZAR.UseVisualStyleBackColor = true;
            this.BACTUALIZAR.Click += new System.EventHandler(this.BACTUALIZAR_Click);
            // 
            // FMODIFICARCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 266);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFECHACHEQ);
            this.Controls.Add(this.TVALCHEQ);
            this.Controls.Add(this.TNUMCHEQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BACTUALIZAR);
            this.Name = "FMODIFICARCHEQUES";
            this.Text = "FMODIFICARCHEQUES";
            this.Load += new System.EventHandler(this.FMODIFICARCHEQUES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TFECHACHEQ;
        private System.Windows.Forms.TextBox TVALCHEQ;
        private System.Windows.Forms.TextBox TNUMCHEQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BACTUALIZAR;
    }
}