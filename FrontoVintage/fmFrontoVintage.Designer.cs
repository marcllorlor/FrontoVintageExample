namespace FrontoVintage
{
    partial class fmFrontoVintage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRebots = new System.Windows.Forms.Label();
            this.lbXocs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRebots
            // 
            this.lbRebots.AutoSize = true;
            this.lbRebots.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRebots.Location = new System.Drawing.Point(32, 33);
            this.lbRebots.Name = "lbRebots";
            this.lbRebots.Size = new System.Drawing.Size(44, 16);
            this.lbRebots.TabIndex = 0;
            this.lbRebots.Text = "label1";
            // 
            // lbXocs
            // 
            this.lbXocs.AutoSize = true;
            this.lbXocs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXocs.Location = new System.Drawing.Point(32, 73);
            this.lbXocs.Name = "lbXocs";
            this.lbXocs.Size = new System.Drawing.Size(44, 16);
            this.lbXocs.TabIndex = 1;
            this.lbXocs.Text = "label1";
            // 
            // fmFrontoVintage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.ControlBox = false;
            this.Controls.Add(this.lbXocs);
            this.Controls.Add(this.lbRebots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmFrontoVintage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmFrontoVintage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmFrontoVintage_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fmFrontoVintage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRebots;
        private System.Windows.Forms.Label lbXocs;
    }
}

