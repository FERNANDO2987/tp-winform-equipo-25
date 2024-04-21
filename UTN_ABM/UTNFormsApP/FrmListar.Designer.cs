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
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 510);
            this.Controls.Add(this.label_Listar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Listar;
    }
}