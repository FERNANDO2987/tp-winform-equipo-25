namespace UTNFormsApP
{
    partial class FrmBuscar
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
            this.label_Buscar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.GroupBox();
            this.dataGridView_Buscar = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Buscar
            // 
            this.label_Buscar.AutoSize = true;
            this.label_Buscar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buscar.Location = new System.Drawing.Point(190, 31);
            this.label_Buscar.Name = "label_Buscar";
            this.label_Buscar.Size = new System.Drawing.Size(245, 39);
            this.label_Buscar.TabIndex = 3;
            this.label_Buscar.Text = "Buscar Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.text_Buscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Articulo";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Buscar.Location = new System.Drawing.Point(557, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(105, 35);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // text_Buscar
            // 
            this.text_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Buscar.Location = new System.Drawing.Point(18, 29);
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.Size = new System.Drawing.Size(518, 23);
            this.text_Buscar.TabIndex = 0;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.dataGridView_Buscar);
            this.Lista.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Lista.Location = new System.Drawing.Point(13, 171);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(683, 362);
            this.Lista.TabIndex = 5;
            this.Lista.TabStop = false;
            this.Lista.Text = "Lista";
            // 
            // dataGridView_Buscar
            // 
            this.dataGridView_Buscar.AllowUserToAddRows = false;
            this.dataGridView_Buscar.AllowUserToDeleteRows = false;
            this.dataGridView_Buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buscar.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Buscar.Name = "dataGridView_Buscar";
            this.dataGridView_Buscar.ReadOnly = true;
            this.dataGridView_Buscar.Size = new System.Drawing.Size(671, 317);
            this.dataGridView_Buscar.TabIndex = 0;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_Limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Limpiar.Location = new System.Drawing.Point(293, 539);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(121, 35);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar Tabla";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox Lista;
        private System.Windows.Forms.DataGridView dataGridView_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}