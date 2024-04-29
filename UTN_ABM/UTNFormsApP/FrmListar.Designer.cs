namespace UTNFormsApP
{
    partial class FrmListar
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
            this.label_Listar = new System.Windows.Forms.Label();
            this.dataGridView_Listar = new System.Windows.Forms.DataGridView();
            this.Lista = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar)).BeginInit();
            this.Lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Listar
            // 
            this.label_Listar.AutoSize = true;
            this.label_Listar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Listar.Location = new System.Drawing.Point(198, 34);
            this.label_Listar.Name = "label_Listar";
            this.label_Listar.Size = new System.Drawing.Size(231, 39);
            this.label_Listar.TabIndex = 4;
            this.label_Listar.Text = "Listar Articulos";
            // 
            // dataGridView_Listar
            // 
            this.dataGridView_Listar.AllowUserToAddRows = false;
            this.dataGridView_Listar.AllowUserToDeleteRows = false;
            this.dataGridView_Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar.Location = new System.Drawing.Point(9, 19);
            this.dataGridView_Listar.Name = "dataGridView_Listar";
            this.dataGridView_Listar.ReadOnly = true;
            this.dataGridView_Listar.Size = new System.Drawing.Size(669, 358);
            this.dataGridView_Listar.TabIndex = 0;
            this.dataGridView_Listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Listar_CellContentClick);
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.dataGridView_Listar);
            this.Lista.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Lista.Location = new System.Drawing.Point(12, 76);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(684, 383);
            this.Lista.TabIndex = 7;
            this.Lista.TabStop = false;
            this.Lista.Text = "Lista";
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.label_Listar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar)).EndInit();
            this.Lista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Listar;
        private System.Windows.Forms.DataGridView dataGridView_Listar;
        private System.Windows.Forms.GroupBox Lista;
    }
}