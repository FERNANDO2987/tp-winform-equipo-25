namespace UTNFormsApP
{
    partial class FrmAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.cbox_Marca = new System.Windows.Forms.ComboBox();
            this.cbox_Categoria = new System.Windows.Forms.ComboBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.text_Precio = new System.Windows.Forms.TextBox();
            this.text_CodArticulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Articulo";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Guardar.Location = new System.Drawing.Point(154, 480);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(385, 35);
            this.btn_Guardar.TabIndex = 14;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.btn_Selecionar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox2.Location = new System.Drawing.Point(365, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 372);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagenes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 247);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Selecionar.FlatAppearance.BorderSize = 0;
            this.btn_Selecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selecionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Selecionar.Location = new System.Drawing.Point(82, 314);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(172, 35);
            this.btn_Selecionar.TabIndex = 15;
            this.btn_Selecionar.Text = "Selecionar Imagen";
            this.btn_Selecionar.UseVisualStyleBackColor = false;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Location = new System.Drawing.Point(16, 98);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(306, 27);
            this.text_Descripcion.TabIndex = 10;
            this.text_Descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Descripcion_KeyDown);
            // 
            // cbox_Marca
            // 
            this.cbox_Marca.FormattingEnabled = true;
            this.cbox_Marca.Location = new System.Drawing.Point(16, 133);
            this.cbox_Marca.Name = "cbox_Marca";
            this.cbox_Marca.Size = new System.Drawing.Size(306, 29);
            this.cbox_Marca.TabIndex = 11;
 
            this.cbox_Marca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Marca_KeyDown);
            // 
            // cbox_Categoria
            // 
            this.cbox_Categoria.FormattingEnabled = true;
            this.cbox_Categoria.Location = new System.Drawing.Point(16, 173);
            this.cbox_Categoria.Name = "cbox_Categoria";
            this.cbox_Categoria.Size = new System.Drawing.Size(306, 29);
            this.cbox_Categoria.TabIndex = 12;
            this.cbox_Categoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Categoria_KeyDown);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(16, 60);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(306, 27);
            this.textNombre.TabIndex = 9;
            this.textNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNombre_KeyDown);
            // 
            // text_Precio
            // 
            this.text_Precio.Location = new System.Drawing.Point(16, 212);
            this.text_Precio.Name = "text_Precio";
            this.text_Precio.Size = new System.Drawing.Size(306, 27);
            this.text_Precio.TabIndex = 13;
            this.text_Precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Precio_KeyDown);
            // 
            // text_CodArticulo
            // 
            this.text_CodArticulo.Location = new System.Drawing.Point(16, 22);
            this.text_CodArticulo.Name = "text_CodArticulo";
            this.text_CodArticulo.Size = new System.Drawing.Size(306, 27);
            this.text_CodArticulo.TabIndex = 8;
            this.text_CodArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_CodArticulo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_CodArticulo);
            this.groupBox1.Controls.Add(this.text_Precio);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.cbox_Categoria);
            this.groupBox1.Controls.Add(this.cbox_Marca);
            this.groupBox1.Controls.Add(this.text_Descripcion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 296);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregar";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.ComboBox cbox_Marca;
        private System.Windows.Forms.ComboBox cbox_Categoria;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox text_Precio;
        private System.Windows.Forms.TextBox text_CodArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}