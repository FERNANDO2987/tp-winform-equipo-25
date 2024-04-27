namespace UTNFormsApP
{
    partial class FrmEliminar
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
            this.label_Eliminar = new System.Windows.Forms.Label();
            this.text_BuscarDetalle = new System.Windows.Forms.TextBox();
            this.btn_BuscarDetalle = new System.Windows.Forms.Button();
            this.dataGridView_Detalles = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Eliminar
            // 
            this.label_Eliminar.AutoSize = true;
            this.label_Eliminar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Eliminar.Location = new System.Drawing.Point(179, 36);
            this.label_Eliminar.Name = "label_Eliminar";
            this.label_Eliminar.Size = new System.Drawing.Size(262, 39);
            this.label_Eliminar.TabIndex = 2;
            this.label_Eliminar.Text = "Eliminar Articulo";
            // 
            // text_BuscarDetalle
            // 
            this.text_BuscarDetalle.Location = new System.Drawing.Point(12, 88);
            this.text_BuscarDetalle.Name = "text_BuscarDetalle";
            this.text_BuscarDetalle.Size = new System.Drawing.Size(460, 20);
            this.text_BuscarDetalle.TabIndex = 3;
            // 
            // btn_BuscarDetalle
            // 
            this.btn_BuscarDetalle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_BuscarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_BuscarDetalle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_BuscarDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BuscarDetalle.Location = new System.Drawing.Point(570, 88);
            this.btn_BuscarDetalle.Name = "btn_BuscarDetalle";
            this.btn_BuscarDetalle.Size = new System.Drawing.Size(114, 20);
            this.btn_BuscarDetalle.TabIndex = 17;
            this.btn_BuscarDetalle.Text = "Buscar";
            this.btn_BuscarDetalle.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Detalles
            // 
            this.dataGridView_Detalles.AllowUserToAddRows = false;
            this.dataGridView_Detalles.AllowUserToDeleteRows = false;
            this.dataGridView_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detalles.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_Detalles.Name = "dataGridView_Detalles";
            this.dataGridView_Detalles.ReadOnly = true;
            this.dataGridView_Detalles.Size = new System.Drawing.Size(672, 218);
            this.dataGridView_Detalles.TabIndex = 18;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Eliminar.Location = new System.Drawing.Point(280, 372);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(114, 30);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dataGridView_Detalles);
            this.Controls.Add(this.btn_BuscarDetalle);
            this.Controls.Add(this.text_BuscarDetalle);
            this.Controls.Add(this.label_Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Eliminar;
        private System.Windows.Forms.TextBox text_BuscarDetalle;
        private System.Windows.Forms.Button btn_BuscarDetalle;
        private System.Windows.Forms.DataGridView dataGridView_Detalles;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}