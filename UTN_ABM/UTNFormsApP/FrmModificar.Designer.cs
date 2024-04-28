namespace UTNFormsApP
{
    partial class FrmModificar
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
            this.label_Modificar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Modificar = new System.Windows.Forms.TextBox();
            this.Modificar = new System.Windows.Forms.GroupBox();
            this.dataGridView_Modificar = new System.Windows.Forms.DataGridView();
            this.btn_ModificarArticulo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Modificar
            // 
            this.label_Modificar.AutoSize = true;
            this.label_Modificar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Modificar.Location = new System.Drawing.Point(172, 35);
            this.label_Modificar.Name = "label_Modificar";
            this.label_Modificar.Size = new System.Drawing.Size(292, 39);
            this.label_Modificar.TabIndex = 1;
            this.label_Modificar.Text = "Modificar Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.text_Modificar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(18, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Articulo a Modificar";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Buscar.Location = new System.Drawing.Point(545, 23);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(114, 33);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // text_Modificar
            // 
            this.text_Modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_Modificar.Location = new System.Drawing.Point(18, 29);
            this.text_Modificar.Name = "text_Modificar";
            this.text_Modificar.Size = new System.Drawing.Size(506, 23);
            this.text_Modificar.TabIndex = 0;
            // 
            // Modificar
            // 
            this.Modificar.Controls.Add(this.dataGridView_Modificar);
            this.Modificar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Modificar.Location = new System.Drawing.Point(18, 172);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(684, 351);
            this.Modificar.TabIndex = 7;
            this.Modificar.TabStop = false;
            this.Modificar.Text = "Modificar";
            // 
            // dataGridView_Modificar
            // 
            this.dataGridView_Modificar.AllowUserToAddRows = false;
            this.dataGridView_Modificar.AllowUserToDeleteRows = false;
            this.dataGridView_Modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Modificar.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Modificar.Name = "dataGridView_Modificar";
            this.dataGridView_Modificar.Size = new System.Drawing.Size(672, 299);
            this.dataGridView_Modificar.TabIndex = 0;
            this.dataGridView_Modificar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModificar_CellEndEdit);
            // 
            // btn_ModificarArticulo
            // 
            this.btn_ModificarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn_ModificarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarArticulo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_ModificarArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ModificarArticulo.Location = new System.Drawing.Point(232, 546);
            this.btn_ModificarArticulo.Name = "btn_ModificarArticulo";
            this.btn_ModificarArticulo.Size = new System.Drawing.Size(174, 33);
            this.btn_ModificarArticulo.TabIndex = 19;
            this.btn_ModificarArticulo.Text = "Modificar Articulo";
            this.btn_ModificarArticulo.UseVisualStyleBackColor = false;
            this.btn_ModificarArticulo.Click += new System.EventHandler(this.btn_ModificarArticulo_Click);
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.btn_ModificarArticulo);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificar";
            this.Text = "FrmModificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Modificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Modificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox text_Modificar;
        private System.Windows.Forms.GroupBox Modificar;
        private System.Windows.Forms.DataGridView dataGridView_Modificar;
        private System.Windows.Forms.Button btn_ModificarArticulo;
    }
}