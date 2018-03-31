namespace CUENTAS_POR_PAGAR_2
{
    partial class FCHEQUES
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNUMCHEQ = new System.Windows.Forms.TextBox();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.BVERTODO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.DGVCHEQUES = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCHEQUES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TNUMCHEQ);
            this.panel1.Controls.Add(this.TNUMFACT);
            this.panel1.Location = new System.Drawing.Point(413, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 81);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NUMERO CHEQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // TNUMCHEQ
            // 
            this.TNUMCHEQ.Location = new System.Drawing.Point(110, 15);
            this.TNUMCHEQ.Margin = new System.Windows.Forms.Padding(2);
            this.TNUMCHEQ.Name = "TNUMCHEQ";
            this.TNUMCHEQ.Size = new System.Drawing.Size(76, 20);
            this.TNUMCHEQ.TabIndex = 9;
            this.TNUMCHEQ.TextChanged += new System.EventHandler(this.TNUMCHEQ_TextChanged);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(110, 46);
            this.TNUMFACT.Margin = new System.Windows.Forms.Padding(2);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(76, 20);
            this.TNUMFACT.TabIndex = 8;
            this.TNUMFACT.TextChanged += new System.EventHandler(this.TNUMFACT_TextChanged);
            // 
            // BVERTODO
            // 
            this.BVERTODO.Location = new System.Drawing.Point(478, 341);
            this.BVERTODO.Name = "BVERTODO";
            this.BVERTODO.Size = new System.Drawing.Size(75, 23);
            this.BVERTODO.TabIndex = 24;
            this.BVERTODO.Text = "VER TODO";
            this.BVERTODO.UseVisualStyleBackColor = true;
            this.BVERTODO.Click += new System.EventHandler(this.BVERTODO_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "BUSCAR CHEQUES POR:";
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(478, 166);
            this.BELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(68, 24);
            this.BELIMINAR.TabIndex = 3;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(478, 102);
            this.BMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(68, 24);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(478, 32);
            this.BAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(68, 24);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // DGVCHEQUES
            // 
            this.DGVCHEQUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCHEQUES.Location = new System.Drawing.Point(72, 32);
            this.DGVCHEQUES.Margin = new System.Windows.Forms.Padding(2);
            this.DGVCHEQUES.Name = "DGVCHEQUES";
            this.DGVCHEQUES.RowTemplate.Height = 24;
            this.DGVCHEQUES.Size = new System.Drawing.Size(336, 318);
            this.DGVCHEQUES.TabIndex = 18;
            // 
            // FCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BVERTODO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.DGVCHEQUES);
            this.Name = "FCHEQUES";
            this.Text = "FCHEQUES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCHEQUES_FormClosed);
            this.Load += new System.EventHandler(this.FCHEQUES_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCHEQUES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNUMCHEQ;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Button BVERTODO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.DataGridView DGVCHEQUES;
    }
}