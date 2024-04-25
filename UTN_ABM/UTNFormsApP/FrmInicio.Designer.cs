namespace UTNFormsApP
{
    partial class FrmInicio
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
            this.label_Inicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Inicio
            // 
            this.label_Inicio.AutoSize = true;
            this.label_Inicio.BackColor = System.Drawing.Color.LightGray;
            this.label_Inicio.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inicio.Location = new System.Drawing.Point(150, 191);
            this.label_Inicio.Name = "label_Inicio";
            this.label_Inicio.Size = new System.Drawing.Size(352, 39);
            this.label_Inicio.TabIndex = 4;
            this.label_Inicio.Text = "Bienvenidos a la ABM";
            this.label_Inicio.Click += new System.EventHandler(this.label_Buscar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(708, 600);
            this.Controls.Add(this.label_Inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Inicio;
    }
}