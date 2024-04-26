namespace UTNFormsApP
{
    partial class FrmDetalle
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
            this.label_Detalle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarDetalle = new System.Windows.Forms.Button();
            this.text_BuscarDetalle = new System.Windows.Forms.TextBox();
            this.dataGridView_Detalles = new System.Windows.Forms.DataGridView();
            this.Detalles = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalles)).BeginInit();
            this.Detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Detalle
            // 
            this.label_Detalle.AutoSize = true;
            this.label_Detalle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Detalle.Location = new System.Drawing.Point(197, 35);
            this.label_Detalle.Name = "label_Detalle";
            this.label_Detalle.Size = new System.Drawing.Size(253, 39);
            this.label_Detalle.TabIndex = 3;
            this.label_Detalle.Text = "Detalle Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BuscarDetalle);
            this.groupBox1.Controls.Add(this.text_BuscarDetalle);
            this.groupBox1.Location = new System.Drawing.Point(18, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Articulo";
            // 
            // btn_BuscarDetalle
            // 
            this.btn_BuscarDetalle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_BuscarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_BuscarDetalle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_BuscarDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BuscarDetalle.Location = new System.Drawing.Point(484, 22);
            this.btn_BuscarDetalle.Name = "btn_BuscarDetalle";
            this.btn_BuscarDetalle.Size = new System.Drawing.Size(114, 30);
            this.btn_BuscarDetalle.TabIndex = 16;
            this.btn_BuscarDetalle.Text = "Buscar";
            this.btn_BuscarDetalle.UseVisualStyleBackColor = false;
            this.btn_BuscarDetalle.Click += new System.EventHandler(this.btn_BuscarDetalle_Click);
            // 
            // text_BuscarDetalle
            // 
            this.text_BuscarDetalle.Location = new System.Drawing.Point(18, 29);
            this.text_BuscarDetalle.Name = "text_BuscarDetalle";
            this.text_BuscarDetalle.Size = new System.Drawing.Size(460, 20);
            this.text_BuscarDetalle.TabIndex = 0;
            // 
            // dataGridView_Detalles
            // 
            this.dataGridView_Detalles.AllowUserToAddRows = false;
            this.dataGridView_Detalles.AllowUserToDeleteRows = false;
            this.dataGridView_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detalles.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Detalles.Name = "dataGridView_Detalles";
            this.dataGridView_Detalles.ReadOnly = true;
            this.dataGridView_Detalles.Size = new System.Drawing.Size(672, 218);
            this.dataGridView_Detalles.TabIndex = 0;
            // 
            // Detalles
            // 
            this.Detalles.Controls.Add(this.dataGridView_Detalles);
            this.Detalles.Location = new System.Drawing.Point(12, 162);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(684, 259);
            this.Detalles.TabIndex = 6;
            this.Detalles.TabStop = false;
            this.Detalles.Text = "Detalles";
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Detalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalle";
            this.Text = "FrmDetalle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalles)).EndInit();
            this.Detalles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Detalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BuscarDetalle;
        private System.Windows.Forms.TextBox text_BuscarDetalle;
        private System.Windows.Forms.DataGridView dataGridView_Detalles;
        private System.Windows.Forms.GroupBox Detalles;
    }
}