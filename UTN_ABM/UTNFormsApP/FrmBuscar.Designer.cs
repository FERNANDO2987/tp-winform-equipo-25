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
            this.SuspendLayout();
            // 
            // label_Buscar
            // 
            this.label_Buscar.AutoSize = true;
            this.label_Buscar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buscar.Location = new System.Drawing.Point(192, 36);
            this.label_Buscar.Name = "label_Buscar";
            this.label_Buscar.Size = new System.Drawing.Size(245, 39);
            this.label_Buscar.TabIndex = 3;
            this.label_Buscar.Text = "Buscar Articulo";
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 510);
            this.Controls.Add(this.label_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Buscar;
    }
}