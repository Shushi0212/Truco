namespace Truco
{
    partial class fmResultado
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(367, 178);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(51, 20);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(12, 392);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(113, 46);
            this.btnAcpetar.TabIndex = 1;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // fmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcpetar);
            this.Controls.Add(this.lblResultado);
            this.Name = "fmResultado";
            this.Text = "fmResultado";
            this.Load += new System.EventHandler(this.fmResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAcpetar;
    }
}