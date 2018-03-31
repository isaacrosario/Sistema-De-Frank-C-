namespace CUENTAS_POR_PAGAR_2
{
    partial class FINICIO
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
            this.DGVUSUARIOS = new System.Windows.Forms.DataGridView();
            this.BENTRADA = new System.Windows.Forms.Button();
            this.TCLAVE = new System.Windows.Forms.TextBox();
            this.TUSUARIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUSUARIOS
            // 
            this.DGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUSUARIOS.Location = new System.Drawing.Point(18, 227);
            this.DGVUSUARIOS.Name = "DGVUSUARIOS";
            this.DGVUSUARIOS.Size = new System.Drawing.Size(546, 150);
            this.DGVUSUARIOS.TabIndex = 28;
            // 
            // BENTRADA
            // 
            this.BENTRADA.Location = new System.Drawing.Point(267, 198);
            this.BENTRADA.Name = "BENTRADA";
            this.BENTRADA.Size = new System.Drawing.Size(75, 23);
            this.BENTRADA.TabIndex = 27;
            this.BENTRADA.Text = "ENTRAR";
            this.BENTRADA.UseVisualStyleBackColor = true;
            this.BENTRADA.Click += new System.EventHandler(this.BENTRADA_Click);
            // 
            // TCLAVE
            // 
            this.TCLAVE.BackColor = System.Drawing.Color.White;
            this.TCLAVE.ForeColor = System.Drawing.Color.Black;
            this.TCLAVE.Location = new System.Drawing.Point(267, 126);
            this.TCLAVE.Name = "TCLAVE";
            this.TCLAVE.Size = new System.Drawing.Size(100, 20);
            this.TCLAVE.TabIndex = 26;
            this.TCLAVE.TextChanged += new System.EventHandler(this.TCLAVE_TextChanged);
            this.TCLAVE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCLAVE_KeyPress);
            // 
            // TUSUARIO
            // 
            this.TUSUARIO.BackColor = System.Drawing.Color.White;
            this.TUSUARIO.ForeColor = System.Drawing.Color.Black;
            this.TUSUARIO.Location = new System.Drawing.Point(267, 65);
            this.TUSUARIO.Name = "TUSUARIO";
            this.TUSUARIO.Size = new System.Drawing.Size(100, 20);
            this.TUSUARIO.TabIndex = 25;
            this.TUSUARIO.TextChanged += new System.EventHandler(this.TUSUARIO_TextChanged);
            this.TUSUARIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUSUARIO_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ESCRIBA LA CONTRASENA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ESCRIBA EL NOMBRE DEL USUARIO:";
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.DGVUSUARIOS);
            this.Controls.Add(this.BENTRADA);
            this.Controls.Add(this.TCLAVE);
            this.Controls.Add(this.TUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FINICIO";
            this.Text = "FINICIO";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUSUARIOS;
        private System.Windows.Forms.Button BENTRADA;
        private System.Windows.Forms.TextBox TCLAVE;
        private System.Windows.Forms.TextBox TUSUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}