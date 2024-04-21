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
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 510);
            this.Controls.Add(this.label_Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Eliminar;
    }
}