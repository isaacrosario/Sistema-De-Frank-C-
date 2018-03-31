namespace CUENTAS_POR_PAGAR_2
{
    partial class FESTADO_DE_CUENTAS
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
            this.TPORNUMEROFACTURA = new System.Windows.Forms.TextBox();
            this.BVERTODO = new System.Windows.Forms.Button();
            this.TPORCODIGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVESTADODECUENTA = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADODECUENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TPORNUMEROFACTURA);
            this.groupBox1.Controls.Add(this.BVERTODO);
            this.groupBox1.Controls.Add(this.TPORCODIGO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR POR :";
            // 
            // TPORNUMEROFACTURA
            // 
            this.TPORNUMEROFACTURA.Location = new System.Drawing.Point(427, 46);
            this.TPORNUMEROFACTURA.Name = "TPORNUMEROFACTURA";
            this.TPORNUMEROFACTURA.Size = new System.Drawing.Size(100, 20);
            this.TPORNUMEROFACTURA.TabIndex = 8;
            this.TPORNUMEROFACTURA.TextChanged += new System.EventHandler(this.TPORNUMEROFACTURA_TextChanged);
            // 
            // BVERTODO
            // 
            this.BVERTODO.Location = new System.Drawing.Point(562, 43);
            this.BVERTODO.Name = "BVERTODO";
            this.BVERTODO.Size = new System.Drawing.Size(75, 23);
            this.BVERTODO.TabIndex = 4;
            this.BVERTODO.Text = "VER TODO";
            this.BVERTODO.UseVisualStyleBackColor = true;
            this.BVERTODO.Click += new System.EventHandler(this.BVERTODO_Click);
            // 
            // TPORCODIGO
            // 
            this.TPORCODIGO.Location = new System.Drawing.Point(174, 49);
            this.TPORCODIGO.Name = "TPORCODIGO";
            this.TPORCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TPORCODIGO.TabIndex = 2;
            this.TPORCODIGO.TextChanged += new System.EventHandler(this.TPORCODIGO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE FACTURA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO DE PROVEEDOR";
            // 
            // DGVESTADODECUENTA
            // 
            this.DGVESTADODECUENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVESTADODECUENTA.Location = new System.Drawing.Point(43, 125);
            this.DGVESTADODECUENTA.Name = "DGVESTADODECUENTA";
            this.DGVESTADODECUENTA.Size = new System.Drawing.Size(672, 302);
            this.DGVESTADODECUENTA.TabIndex = 2;
            // 
            // FESTADO_DE_CUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVESTADODECUENTA);
            this.Name = "FESTADO_DE_CUENTAS";
            this.Text = "FESTADO_DE_CUENTAS";
            this.Load += new System.EventHandler(this.FESTADO_DE_CUENTAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADODECUENTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TPORNUMEROFACTURA;
        private System.Windows.Forms.Button BVERTODO;
        private System.Windows.Forms.TextBox TPORCODIGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVESTADODECUENTA;
    }
}