namespace CUENTAS_POR_PAGAR_2
{
    partial class FAGREGARFACT
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
            this.TFECHAVENC = new System.Windows.Forms.TextBox();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TFECHAFACT = new System.Windows.Forms.TextBox();
            this.TVALFACT = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TFECHAVENC
            // 
            this.TFECHAVENC.Location = new System.Drawing.Point(197, 173);
            this.TFECHAVENC.Margin = new System.Windows.Forms.Padding(2);
            this.TFECHAVENC.Name = "TFECHAVENC";
            this.TFECHAVENC.Size = new System.Drawing.Size(156, 20);
            this.TFECHAVENC.TabIndex = 20;
            this.TFECHAVENC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHAVENC_KeyPress);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(167, 228);
            this.BAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(74, 25);
            this.BAGREGAR.TabIndex = 21;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TFECHAFACT
            // 
            this.TFECHAFACT.Location = new System.Drawing.Point(197, 142);
            this.TFECHAFACT.Margin = new System.Windows.Forms.Padding(2);
            this.TFECHAFACT.Name = "TFECHAFACT";
            this.TFECHAFACT.Size = new System.Drawing.Size(156, 20);
            this.TFECHAFACT.TabIndex = 19;
            this.TFECHAFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHAFACT_KeyPress);
            // 
            // TVALFACT
            // 
            this.TVALFACT.Location = new System.Drawing.Point(197, 116);
            this.TVALFACT.Margin = new System.Windows.Forms.Padding(2);
            this.TVALFACT.Name = "TVALFACT";
            this.TVALFACT.Size = new System.Drawing.Size(156, 20);
            this.TVALFACT.TabIndex = 18;
            this.TVALFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVALFACT_KeyPress);
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(197, 82);
            this.TCODIGO.Margin = new System.Windows.Forms.Padding(2);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(156, 20);
            this.TCODIGO.TabIndex = 17;
            this.TCODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCODIGO_KeyPress);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(197, 49);
            this.TNUMFACT.Margin = new System.Windows.Forms.Padding(2);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(105, 20);
            this.TNUMFACT.TabIndex = 16;
            this.TNUMFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMFACT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FECHA VENCIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FECHA FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "VALOR FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CODIGO CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // FAGREGARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 303);
            this.Controls.Add(this.TFECHAVENC);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.TFECHAFACT);
            this.Controls.Add(this.TVALFACT);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARFACT";
            this.Text = "FAGREGARFACT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TFECHAVENC;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TFECHAFACT;
        private System.Windows.Forms.TextBox TVALFACT;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}