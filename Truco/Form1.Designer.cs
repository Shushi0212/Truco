namespace Truco
{
    partial class Truco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truco));
            this.pnlOperaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnvido = new System.Windows.Forms.Button();
            this.btnRealEnvido = new System.Windows.Forms.Button();
            this.btnFaltaEnvido = new System.Windows.Forms.Button();
            this.btnTruco = new System.Windows.Forms.Button();
            this.btnVoyAlMazo = new System.Windows.Forms.Button();
            this.pnlMisTresCartas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMisCartasCarta1 = new System.Windows.Forms.Button();
            this.btnMisCartasCarta2 = new System.Windows.Forms.Button();
            this.btnMisCartasCarta3 = new System.Windows.Forms.Button();
            this.btnMisMesaCarta1 = new System.Windows.Forms.Button();
            this.labelMIO = new System.Windows.Forms.Label();
            this.labelSUS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.llbCPU = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.ImgComputadoraGrupo3 = new System.Windows.Forms.PictureBox();
            this.ImgComputadoraGrupo2 = new System.Windows.Forms.PictureBox();
            this.ImgComputadoraGrupo1 = new System.Windows.Forms.PictureBox();
            this.ImgJugadorGrupo3 = new System.Windows.Forms.PictureBox();
            this.ImgJugadorGrupo2 = new System.Windows.Forms.PictureBox();
            this.ImgJugadorGrupo1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOperaciones.SuspendLayout();
            this.pnlMisTresCartas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.Controls.Add(this.btnEnvido);
            this.pnlOperaciones.Controls.Add(this.btnRealEnvido);
            this.pnlOperaciones.Controls.Add(this.btnFaltaEnvido);
            this.pnlOperaciones.Controls.Add(this.btnTruco);
            this.pnlOperaciones.Controls.Add(this.btnVoyAlMazo);
            this.pnlOperaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOperaciones.Location = new System.Drawing.Point(0, 612);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(1258, 52);
            this.pnlOperaciones.TabIndex = 3;
            // 
            // btnEnvido
            // 
            this.btnEnvido.Location = new System.Drawing.Point(3, 3);
            this.btnEnvido.Name = "btnEnvido";
            this.btnEnvido.Size = new System.Drawing.Size(154, 48);
            this.btnEnvido.TabIndex = 4;
            this.btnEnvido.Text = "Envido";
            this.btnEnvido.UseVisualStyleBackColor = true;
            this.btnEnvido.Click += new System.EventHandler(this.btnEnvido_Click);
            // 
            // btnRealEnvido
            // 
            this.btnRealEnvido.Location = new System.Drawing.Point(163, 3);
            this.btnRealEnvido.Name = "btnRealEnvido";
            this.btnRealEnvido.Size = new System.Drawing.Size(154, 48);
            this.btnRealEnvido.TabIndex = 5;
            this.btnRealEnvido.Text = "Real Envido";
            this.btnRealEnvido.UseVisualStyleBackColor = true;
            this.btnRealEnvido.Click += new System.EventHandler(this.btnRealEnvido_Click);
            // 
            // btnFaltaEnvido
            // 
            this.btnFaltaEnvido.Location = new System.Drawing.Point(323, 3);
            this.btnFaltaEnvido.Name = "btnFaltaEnvido";
            this.btnFaltaEnvido.Size = new System.Drawing.Size(154, 48);
            this.btnFaltaEnvido.TabIndex = 6;
            this.btnFaltaEnvido.Text = "Falta Envido";
            this.btnFaltaEnvido.UseVisualStyleBackColor = true;
            this.btnFaltaEnvido.Click += new System.EventHandler(this.btnFaltaEnvido_Click);
            // 
            // btnTruco
            // 
            this.btnTruco.Location = new System.Drawing.Point(483, 3);
            this.btnTruco.Name = "btnTruco";
            this.btnTruco.Size = new System.Drawing.Size(154, 48);
            this.btnTruco.TabIndex = 7;
            this.btnTruco.Text = "Truco";
            this.btnTruco.UseVisualStyleBackColor = true;
            // 
            // btnVoyAlMazo
            // 
            this.btnVoyAlMazo.Location = new System.Drawing.Point(643, 3);
            this.btnVoyAlMazo.Name = "btnVoyAlMazo";
            this.btnVoyAlMazo.Size = new System.Drawing.Size(154, 48);
            this.btnVoyAlMazo.TabIndex = 12;
            this.btnVoyAlMazo.Text = "Me Voy al Mazo";
            this.btnVoyAlMazo.UseVisualStyleBackColor = true;
            this.btnVoyAlMazo.Click += new System.EventHandler(this.btnVoyAlMazo_Click);
            // 
            // pnlMisTresCartas
            // 
            this.pnlMisTresCartas.Controls.Add(this.btnMisCartasCarta1);
            this.pnlMisTresCartas.Controls.Add(this.btnMisCartasCarta2);
            this.pnlMisTresCartas.Controls.Add(this.btnMisCartasCarta3);
            this.pnlMisTresCartas.Location = new System.Drawing.Point(0, 354);
            this.pnlMisTresCartas.Name = "pnlMisTresCartas";
            this.pnlMisTresCartas.Size = new System.Drawing.Size(918, 258);
            this.pnlMisTresCartas.TabIndex = 6;
            // 
            // btnMisCartasCarta1
            // 
            this.btnMisCartasCarta1.AutoSize = true;
            this.btnMisCartasCarta1.FlatAppearance.BorderSize = 0;
            this.btnMisCartasCarta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCartasCarta1.Location = new System.Drawing.Point(3, 3);
            this.btnMisCartasCarta1.Name = "btnMisCartasCarta1";
            this.btnMisCartasCarta1.Size = new System.Drawing.Size(104, 160);
            this.btnMisCartasCarta1.TabIndex = 3;
            this.btnMisCartasCarta1.UseVisualStyleBackColor = true;
            this.btnMisCartasCarta1.Click += new System.EventHandler(this.btnMisCartasCarta1_Click);
            // 
            // btnMisCartasCarta2
            // 
            this.btnMisCartasCarta2.AutoSize = true;
            this.btnMisCartasCarta2.FlatAppearance.BorderSize = 0;
            this.btnMisCartasCarta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCartasCarta2.Location = new System.Drawing.Point(113, 3);
            this.btnMisCartasCarta2.Name = "btnMisCartasCarta2";
            this.btnMisCartasCarta2.Size = new System.Drawing.Size(104, 160);
            this.btnMisCartasCarta2.TabIndex = 1;
            this.btnMisCartasCarta2.UseVisualStyleBackColor = true;
            // 
            // btnMisCartasCarta3
            // 
            this.btnMisCartasCarta3.AutoSize = true;
            this.btnMisCartasCarta3.FlatAppearance.BorderSize = 0;
            this.btnMisCartasCarta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCartasCarta3.Location = new System.Drawing.Point(223, 3);
            this.btnMisCartasCarta3.Name = "btnMisCartasCarta3";
            this.btnMisCartasCarta3.Size = new System.Drawing.Size(104, 160);
            this.btnMisCartasCarta3.TabIndex = 2;
            this.btnMisCartasCarta3.UseVisualStyleBackColor = true;
            // 
            // btnMisMesaCarta1
            // 
            this.btnMisMesaCarta1.AutoSize = true;
            this.btnMisMesaCarta1.FlatAppearance.BorderSize = 0;
            this.btnMisMesaCarta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisMesaCarta1.Location = new System.Drawing.Point(190, 0);
            this.btnMisMesaCarta1.Name = "btnMisMesaCarta1";
            this.btnMisMesaCarta1.Size = new System.Drawing.Size(104, 160);
            this.btnMisMesaCarta1.TabIndex = 8;
            this.btnMisMesaCarta1.UseVisualStyleBackColor = true;
            // 
            // labelMIO
            // 
            this.labelMIO.AutoSize = true;
            this.labelMIO.Location = new System.Drawing.Point(77, 104);
            this.labelMIO.Name = "labelMIO";
            this.labelMIO.Size = new System.Drawing.Size(51, 20);
            this.labelMIO.TabIndex = 9;
            this.labelMIO.Text = "label1";
            // 
            // labelSUS
            // 
            this.labelSUS.AutoSize = true;
            this.labelSUS.Location = new System.Drawing.Point(238, 104);
            this.labelSUS.Name = "labelSUS";
            this.labelSUS.Size = new System.Drawing.Size(51, 20);
            this.labelSUS.TabIndex = 10;
            this.labelSUS.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.llbCPU);
            this.panel1.Controls.Add(this.labelMIO);
            this.panel1.Controls.Add(this.labelSUS);
            this.panel1.Controls.Add(this.lblJugador);
            this.panel1.Controls.Add(this.ImgComputadoraGrupo3);
            this.panel1.Controls.Add(this.ImgComputadoraGrupo2);
            this.panel1.Controls.Add(this.ImgComputadoraGrupo1);
            this.panel1.Controls.Add(this.ImgJugadorGrupo3);
            this.panel1.Controls.Add(this.ImgJugadorGrupo2);
            this.panel1.Controls.Add(this.ImgJugadorGrupo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(918, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 612);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tanteador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llbCPU
            // 
            this.llbCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbCPU.AutoSize = true;
            this.llbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCPU.Image = ((System.Drawing.Image)(resources.GetObject("llbCPU.Image")));
            this.llbCPU.Location = new System.Drawing.Point(227, 70);
            this.llbCPU.Name = "llbCPU";
            this.llbCPU.Size = new System.Drawing.Size(75, 25);
            this.llbCPU.TabIndex = 13;
            this.llbCPU.Text = "C.P.U.";
            // 
            // lblJugador
            // 
            this.lblJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Image = ((System.Drawing.Image)(resources.GetObject("lblJugador.Image")));
            this.lblJugador.Location = new System.Drawing.Point(55, 70);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(91, 25);
            this.lblJugador.TabIndex = 12;
            this.lblJugador.Text = "Jugador";
            // 
            // ImgComputadoraGrupo3
            // 
            this.ImgComputadoraGrupo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgComputadoraGrupo3.Image = ((System.Drawing.Image)(resources.GetObject("ImgComputadoraGrupo3.Image")));
            this.ImgComputadoraGrupo3.Location = new System.Drawing.Point(186, 454);
            this.ImgComputadoraGrupo3.Name = "ImgComputadoraGrupo3";
            this.ImgComputadoraGrupo3.Size = new System.Drawing.Size(142, 142);
            this.ImgComputadoraGrupo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgComputadoraGrupo3.TabIndex = 5;
            this.ImgComputadoraGrupo3.TabStop = false;
            // 
            // ImgComputadoraGrupo2
            // 
            this.ImgComputadoraGrupo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgComputadoraGrupo2.Image = ((System.Drawing.Image)(resources.GetObject("ImgComputadoraGrupo2.Image")));
            this.ImgComputadoraGrupo2.Location = new System.Drawing.Point(188, 297);
            this.ImgComputadoraGrupo2.Name = "ImgComputadoraGrupo2";
            this.ImgComputadoraGrupo2.Size = new System.Drawing.Size(142, 142);
            this.ImgComputadoraGrupo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgComputadoraGrupo2.TabIndex = 4;
            this.ImgComputadoraGrupo2.TabStop = false;
            // 
            // ImgComputadoraGrupo1
            // 
            this.ImgComputadoraGrupo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgComputadoraGrupo1.Image = ((System.Drawing.Image)(resources.GetObject("ImgComputadoraGrupo1.Image")));
            this.ImgComputadoraGrupo1.Location = new System.Drawing.Point(188, 141);
            this.ImgComputadoraGrupo1.Name = "ImgComputadoraGrupo1";
            this.ImgComputadoraGrupo1.Size = new System.Drawing.Size(142, 142);
            this.ImgComputadoraGrupo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgComputadoraGrupo1.TabIndex = 3;
            this.ImgComputadoraGrupo1.TabStop = false;
            // 
            // ImgJugadorGrupo3
            // 
            this.ImgJugadorGrupo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgJugadorGrupo3.Image = ((System.Drawing.Image)(resources.GetObject("ImgJugadorGrupo3.Image")));
            this.ImgJugadorGrupo3.Location = new System.Drawing.Point(24, 454);
            this.ImgJugadorGrupo3.Name = "ImgJugadorGrupo3";
            this.ImgJugadorGrupo3.Size = new System.Drawing.Size(142, 142);
            this.ImgJugadorGrupo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgJugadorGrupo3.TabIndex = 2;
            this.ImgJugadorGrupo3.TabStop = false;
            // 
            // ImgJugadorGrupo2
            // 
            this.ImgJugadorGrupo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgJugadorGrupo2.Image = ((System.Drawing.Image)(resources.GetObject("ImgJugadorGrupo2.Image")));
            this.ImgJugadorGrupo2.Location = new System.Drawing.Point(24, 297);
            this.ImgJugadorGrupo2.Name = "ImgJugadorGrupo2";
            this.ImgJugadorGrupo2.Size = new System.Drawing.Size(142, 142);
            this.ImgJugadorGrupo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgJugadorGrupo2.TabIndex = 1;
            this.ImgJugadorGrupo2.TabStop = false;
            // 
            // ImgJugadorGrupo1
            // 
            this.ImgJugadorGrupo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgJugadorGrupo1.Image = global::Truco.Properties.Resources._5_fw;
            this.ImgJugadorGrupo1.Location = new System.Drawing.Point(24, 141);
            this.ImgJugadorGrupo1.Name = "ImgJugadorGrupo1";
            this.ImgJugadorGrupo1.Size = new System.Drawing.Size(142, 142);
            this.ImgJugadorGrupo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgJugadorGrupo1.TabIndex = 0;
            this.ImgJugadorGrupo1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMisTresCartas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 612);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Truco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMisMesaCarta1);
            this.Controls.Add(this.pnlOperaciones);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Truco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperaciones.ResumeLayout(false);
            this.pnlMisTresCartas.ResumeLayout(false);
            this.pnlMisTresCartas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputadoraGrupo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJugadorGrupo1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlOperaciones;
        private System.Windows.Forms.Button btnEnvido;
        private System.Windows.Forms.Button btnRealEnvido;
        private System.Windows.Forms.Button btnFaltaEnvido;
        private System.Windows.Forms.Button btnTruco;
        private System.Windows.Forms.Button btnVoyAlMazo;
        private System.Windows.Forms.FlowLayoutPanel pnlMisTresCartas;
        private System.Windows.Forms.Button btnMisCartasCarta2;
        private System.Windows.Forms.Button btnMisCartasCarta3;
        private System.Windows.Forms.Button btnMisCartasCarta1;
        private System.Windows.Forms.Button btnMisMesaCarta1;
        private System.Windows.Forms.Label labelMIO;
        private System.Windows.Forms.Label labelSUS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgJugadorGrupo1;
        private System.Windows.Forms.Label llbCPU;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.PictureBox ImgComputadoraGrupo3;
        private System.Windows.Forms.PictureBox ImgComputadoraGrupo2;
        private System.Windows.Forms.PictureBox ImgComputadoraGrupo1;
        private System.Windows.Forms.PictureBox ImgJugadorGrupo3;
        private System.Windows.Forms.PictureBox ImgJugadorGrupo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

