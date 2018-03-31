namespace CUENTAS_POR_PAGAR_2
{
    partial class FPROVEEDORES
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
            this.BLIMPIAR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TNOMBRE = new System.Windows.Forms.TextBox();
            this.TTELEFONO = new System.Windows.Forms.TextBox();
            this.TCIUDAD = new System.Windows.Forms.TextBox();
            this.TDIRECCION = new System.Windows.Forms.TextBox();
            this.TAPELLIDOS = new System.Windows.Forms.TextBox();
            this.DGVPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BAGREGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLIMPIAR
            // 
            this.BLIMPIAR.Location = new System.Drawing.Point(612, 413);
            this.BLIMPIAR.Name = "BLIMPIAR";
            this.BLIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BLIMPIAR.TabIndex = 13;
            this.BLIMPIAR.Text = "LIMPIAR";
            this.BLIMPIAR.UseVisualStyleBackColor = true;
            this.BLIMPIAR.Click += new System.EventHandler(this.BLIMPIAR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "BUSCAR PROVEEDORES POR:";
            // 
            // TNOMBRE
            // 
            this.TNOMBRE.BackColor = System.Drawing.Color.White;
            this.TNOMBRE.Location = new System.Drawing.Point(118, 68);
            this.TNOMBRE.Name = "TNOMBRE";
            this.TNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TNOMBRE.TabIndex = 15;
            this.TNOMBRE.TextChanged += new System.EventHandler(this.TNOMBRE_TextChanged);
            this.TNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNOMBRE_KeyPress);
            // 
            // TTELEFONO
            // 
            this.TTELEFONO.BackColor = System.Drawing.Color.White;
            this.TTELEFONO.Location = new System.Drawing.Point(118, 222);
            this.TTELEFONO.Name = "TTELEFONO";
            this.TTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.TTELEFONO.TabIndex = 13;
            // 
            // TCIUDAD
            // 
            this.TCIUDAD.BackColor = System.Drawing.Color.White;
            this.TCIUDAD.Location = new System.Drawing.Point(118, 180);
            this.TCIUDAD.Name = "TCIUDAD";
            this.TCIUDAD.Size = new System.Drawing.Size(100, 20);
            this.TCIUDAD.TabIndex = 12;
            this.TCIUDAD.TextChanged += new System.EventHandler(this.TCIUDAD_TextChanged);
            this.TCIUDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCIUDAD_KeyPress);
            // 
            // TDIRECCION
            // 
            this.TDIRECCION.BackColor = System.Drawing.Color.White;
            this.TDIRECCION.Location = new System.Drawing.Point(118, 144);
            this.TDIRECCION.Name = "TDIRECCION";
            this.TDIRECCION.Size = new System.Drawing.Size(100, 20);
            this.TDIRECCION.TabIndex = 11;
            this.TDIRECCION.TextChanged += new System.EventHandler(this.TDIRECCION_TextChanged);
            this.TDIRECCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDIRECCION_KeyPress);
            // 
            // TAPELLIDOS
            // 
            this.TAPELLIDOS.BackColor = System.Drawing.Color.White;
            this.TAPELLIDOS.Location = new System.Drawing.Point(118, 110);
            this.TAPELLIDOS.Name = "TAPELLIDOS";
            this.TAPELLIDOS.Size = new System.Drawing.Size(100, 20);
            this.TAPELLIDOS.TabIndex = 8;
            this.TAPELLIDOS.TextChanged += new System.EventHandler(this.TAPELLIDOS_TextChanged);
            this.TAPELLIDOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAPELLIDOS_KeyPress);
            // 
            // DGVPROVEEDORES
            // 
            this.DGVPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROVEEDORES.Location = new System.Drawing.Point(32, 106);
            this.DGVPROVEEDORES.Name = "DGVPROVEEDORES";
            this.DGVPROVEEDORES.Size = new System.Drawing.Size(454, 330);
            this.DGVPROVEEDORES.TabIndex = 10;
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(386, 47);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BELIMINAR.TabIndex = 3;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(218, 47);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // TCODIGO
            // 
            this.TCODIGO.BackColor = System.Drawing.Color.White;
            this.TCODIGO.Location = new System.Drawing.Point(118, 25);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TCODIGO.TabIndex = 6;
            this.TCODIGO.TextChanged += new System.EventHandler(this.TCODIGO_TextChanged);
            this.TCODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCODIGO_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CIUDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIRECCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TNOMBRE);
            this.panel1.Controls.Add(this.TTELEFONO);
            this.panel1.Controls.Add(this.TCIUDAD);
            this.panel1.Controls.Add(this.TDIRECCION);
            this.panel1.Controls.Add(this.TAPELLIDOS);
            this.panel1.Controls.Add(this.TCODIGO);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(494, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 265);
            this.panel1.TabIndex = 11;
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(51, 47);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // FPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 483);
            this.Controls.Add(this.BLIMPIAR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGVPROVEEDORES);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BAGREGAR);
            this.Name = "FPROVEEDORES";
            this.Text = "FPROVEEDORES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPROVEEDORES_FormClosed);
            this.Load += new System.EventHandler(this.FPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLIMPIAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TNOMBRE;
        private System.Windows.Forms.TextBox TTELEFONO;
        private System.Windows.Forms.TextBox TCIUDAD;
        private System.Windows.Forms.TextBox TDIRECCION;
        private System.Windows.Forms.TextBox TAPELLIDOS;
        private System.Windows.Forms.DataGridView DGVPROVEEDORES;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAGREGAR;
    }
}