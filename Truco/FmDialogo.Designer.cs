namespace Truco
{
    partial class FmDialogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDialogo));
            this.imageListDialogo = new System.Windows.Forms.ImageList(this.components);
            this.btnQuiero = new System.Windows.Forms.Button();
            this.btnNoQuiero = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMensajeEnvido = new System.Windows.Forms.Button();
            this.pnlBtnPrincipales = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOperaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnvido = new System.Windows.Forms.Button();
            this.btnRealEnvido = new System.Windows.Forms.Button();
            this.btnFaltaEnvido = new System.Windows.Forms.Button();
            this.pnlBtnPrincipales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListDialogo
            // 
            this.imageListDialogo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListDialogo.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListDialogo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnQuiero
            // 
            this.btnQuiero.BackColor = System.Drawing.Color.Lime;
            this.btnQuiero.FlatAppearance.BorderSize = 0;
            this.btnQuiero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiero.Location = new System.Drawing.Point(6, 6);
            this.btnQuiero.Name = "btnQuiero";
            this.btnQuiero.Size = new System.Drawing.Size(360, 64);
            this.btnQuiero.TabIndex = 9;
            this.btnQuiero.Text = "Quiero";
            this.btnQuiero.UseVisualStyleBackColor = false;
            this.btnQuiero.Click += new System.EventHandler(this.btnQuiero_Click);
            // 
            // btnNoQuiero
            // 
            this.btnNoQuiero.BackColor = System.Drawing.Color.Red;
            this.btnNoQuiero.FlatAppearance.BorderSize = 0;
            this.btnNoQuiero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoQuiero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoQuiero.ForeColor = System.Drawing.Color.White;
            this.btnNoQuiero.Location = new System.Drawing.Point(368, 6);
            this.btnNoQuiero.Name = "btnNoQuiero";
            this.btnNoQuiero.Size = new System.Drawing.Size(358, 64);
            this.btnNoQuiero.TabIndex = 11;
            this.btnNoQuiero.Text = "NO Quiero";
            this.btnNoQuiero.UseVisualStyleBackColor = false;
            this.btnNoQuiero.Click += new System.EventHandler(this.btnNoQuiero_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMensajeEnvido
            // 
            this.btnMensajeEnvido.BackColor = System.Drawing.Color.Lime;
            this.btnMensajeEnvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajeEnvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensajeEnvido.Location = new System.Drawing.Point(3, 74);
            this.btnMensajeEnvido.Name = "btnMensajeEnvido";
            this.btnMensajeEnvido.Size = new System.Drawing.Size(723, 64);
            this.btnMensajeEnvido.TabIndex = 12;
            this.btnMensajeEnvido.Text = "Quiero";
            this.btnMensajeEnvido.UseVisualStyleBackColor = false;
            this.btnMensajeEnvido.Click += new System.EventHandler(this.btnMensajeEnvido_Click);
            // 
            // pnlBtnPrincipales
            // 
            this.pnlBtnPrincipales.Controls.Add(this.btnMensajeEnvido);
            this.pnlBtnPrincipales.Controls.Add(this.btnQuiero);
            this.pnlBtnPrincipales.Controls.Add(this.btnNoQuiero);
            this.pnlBtnPrincipales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnPrincipales.Location = new System.Drawing.Point(0, 422);
            this.pnlBtnPrincipales.Name = "pnlBtnPrincipales";
            this.pnlBtnPrincipales.Size = new System.Drawing.Size(726, 150);
            this.pnlBtnPrincipales.TabIndex = 7;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(281, 80);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(225, 57);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "lblRespuesta";
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblRespuesta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 422);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlOperaciones);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 422);
            this.panel3.TabIndex = 8;
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOperaciones.Controls.Add(this.btnEnvido);
            this.pnlOperaciones.Controls.Add(this.btnRealEnvido);
            this.pnlOperaciones.Controls.Add(this.btnFaltaEnvido);
            this.pnlOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(183, 422);
            this.pnlOperaciones.TabIndex = 5;
            // 
            // btnEnvido
            // 
            this.btnEnvido.Location = new System.Drawing.Point(3, 3);
            this.btnEnvido.Name = "btnEnvido";
            this.btnEnvido.Size = new System.Drawing.Size(160, 64);
            this.btnEnvido.TabIndex = 4;
            this.btnEnvido.Text = "Envido";
            this.btnEnvido.UseVisualStyleBackColor = true;
            this.btnEnvido.Click += new System.EventHandler(this.btnEnvido_Click);
            // 
            // btnRealEnvido
            // 
            this.btnRealEnvido.Location = new System.Drawing.Point(3, 73);
            this.btnRealEnvido.Name = "btnRealEnvido";
            this.btnRealEnvido.Size = new System.Drawing.Size(160, 64);
            this.btnRealEnvido.TabIndex = 5;
            this.btnRealEnvido.Text = "Real Envido";
            this.btnRealEnvido.UseVisualStyleBackColor = true;
            this.btnRealEnvido.Click += new System.EventHandler(this.btnRealEnvido_Click);
            // 
            // btnFaltaEnvido
            // 
            this.btnFaltaEnvido.Location = new System.Drawing.Point(3, 143);
            this.btnFaltaEnvido.Name = "btnFaltaEnvido";
            this.btnFaltaEnvido.Size = new System.Drawing.Size(160, 64);
            this.btnFaltaEnvido.TabIndex = 6;
            this.btnFaltaEnvido.Text = "Falta Envido";
            this.btnFaltaEnvido.UseVisualStyleBackColor = true;
            this.btnFaltaEnvido.Click += new System.EventHandler(this.btnFaltaEnvido_Click);
            // 
            // FmDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(726, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBtnPrincipales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FmDialogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmDialogo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FmDialogo_Load);
            this.pnlBtnPrincipales.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListDialogo;
        private System.Windows.Forms.Button btnQuiero;
        private System.Windows.Forms.Button btnNoQuiero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMensajeEnvido;
        private System.Windows.Forms.Panel pnlBtnPrincipales;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel pnlOperaciones;
        private System.Windows.Forms.Button btnEnvido;
        private System.Windows.Forms.Button btnRealEnvido;
        private System.Windows.Forms.Button btnFaltaEnvido;
    }
}