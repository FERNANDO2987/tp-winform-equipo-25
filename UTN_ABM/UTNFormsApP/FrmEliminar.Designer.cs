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
            this.dataGridView_Eliminar = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.groupBoxEliminarArticulo = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.text_EliminarArticulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eliminar)).BeginInit();
            this.groupBoxEliminarArticulo.SuspendLayout();
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
            // dataGridView_Eliminar
            // 
            this.dataGridView_Eliminar.AllowUserToAddRows = false;
            this.dataGridView_Eliminar.AllowUserToDeleteRows = false;
            this.dataGridView_Eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eliminar.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_Eliminar.Name = "dataGridView_Eliminar";
            this.dataGridView_Eliminar.ReadOnly = true;
            this.dataGridView_Eliminar.Size = new System.Drawing.Size(672, 218);
            this.dataGridView_Eliminar.TabIndex = 18;
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
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // groupBoxEliminarArticulo
            // 
            this.groupBoxEliminarArticulo.Controls.Add(this.btnBuscar);
            this.groupBoxEliminarArticulo.Controls.Add(this.text_EliminarArticulo);
            this.groupBoxEliminarArticulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBoxEliminarArticulo.Location = new System.Drawing.Point(12, 78);
            this.groupBoxEliminarArticulo.Name = "groupBoxEliminarArticulo";
            this.groupBoxEliminarArticulo.Size = new System.Drawing.Size(684, 66);
            this.groupBoxEliminarArticulo.TabIndex = 21;
            this.groupBoxEliminarArticulo.TabStop = false;
            this.groupBoxEliminarArticulo.Text = "Articulo a eliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(545, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 33);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // text_EliminarArticulo
            // 
            this.text_EliminarArticulo.AccessibleName = "";
            this.text_EliminarArticulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_EliminarArticulo.Location = new System.Drawing.Point(18, 29);
            this.text_EliminarArticulo.Name = "text_EliminarArticulo";
            this.text_EliminarArticulo.Size = new System.Drawing.Size(506, 23);
            this.text_EliminarArticulo.TabIndex = 0;
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.groupBoxEliminarArticulo);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dataGridView_Eliminar);
            this.Controls.Add(this.label_Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eliminar)).EndInit();
            this.groupBoxEliminarArticulo.ResumeLayout(false);
            this.groupBoxEliminarArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.GroupBox groupBoxEliminarArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox text_EliminarArticulo;
    }
}