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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Buscar
            // 
            this.label_Buscar.AutoSize = true;
            this.label_Buscar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buscar.Location = new System.Drawing.Point(192, 20);
            this.label_Buscar.Name = "label_Buscar";
            this.label_Buscar.Size = new System.Drawing.Size(245, 39);
            this.label_Buscar.TabIndex = 3;
            this.label_Buscar.Text = "Buscar Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Articulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Buscar.Location = new System.Drawing.Point(493, 25);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(105, 24);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.dataGridView1);
            this.Lista.Location = new System.Drawing.Point(13, 171);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(615, 198);
            this.Lista.TabIndex = 5;
            this.Lista.TabStop = false;
            this.Lista.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(580, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 510);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox Lista;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}