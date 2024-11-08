using Arquitectura.Entidades;
using Arquitectura.Negocios;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace Truco
{
    public partial class FmDialogo : Form
    {
        public Mano MANO;
        
        public string ACCION;

        public Tanteador Tanteador;
        
        public bool CantaJugador = true;
        


        public FmDialogo()
        {
            InitializeComponent();
            this.Opacity = 1; // Ajusta el nivel de opacidad entre 0 (transparente) y 1 (opaco)
        }

        private void FmDialogo_Load(object sender, EventArgs e)
        {
            btnEnvido.Visible = !MANO.SoyMano;
            btnMensajeEnvido.Visible = false;
            if (CantaJugador)
                AnalizaAccionCuandoSoyMano();
            else
                lblRespuesta.Text = ACCION;
            
        }

        /*Este Metodo analiza la acción cuando el jugador es MANO*/
        private void AnalizaAccionCuandoSoyMano()
        {

            

            lblRespuesta.Text = ComputadoraBss.CriterioQuieroTanto(MANO, ACCION);


            pnlOperaciones.Visible = (lblRespuesta.Text != "NO QUIERO");
            btnQuiero.Visible = (lblRespuesta.Text != "NO QUIERO");
            btnNoQuiero.Visible = (lblRespuesta.Text != "NO QUIERO");
            
            if (lblRespuesta.Text == "NO QUIERO")
            {
                timer1.Enabled = true;
                timer1.Interval = 1500;
                
                Tanteador.MisPuntos += PuntosCuandoNoSeQuiere();

                // Esto otorga un Punto.
                //Thread.Sleep(3000);
                //this.DialogResult = DialogResult.Cancel;
            }
            else if (lblRespuesta.Text.Contains("QUIERO"))
            {
                
                btnEnvido.Visible = false;
                btnRealEnvido.Visible = false;
                btnFaltaEnvido.Visible = false;
                btnNoQuiero.Visible = false;
                btnQuiero.Visible = false;
                btnMensajeEnvido.Visible = true;

                if ((MANO.SuTanto > MANO.MiTanto) || (MANO.SuTanto == MANO.MiTanto && !MANO.SoyMano))
                {
                    

                    btnMensajeEnvido.Text = "SON BUENAS!";
                    btnMensajeEnvido.BackColor = Color.Red;
                    btnMensajeEnvido.ForeColor = Color.White;
                    Tanteador.SusPuntos += PuntosCuandoSeQuiere();

                }
                else
                {
                    btnMensajeEnvido.BackColor = Color.LightGreen;
                    Tanteador.MisPuntos += PuntosCuandoSeQuiere();

                    if (MANO.SuTanto == MANO.MiTanto)
                        btnMensajeEnvido.Text = MANO.MiTanto.ToString() + " DE MANO!";
                    else
                        btnMensajeEnvido.Text = MANO.MiTanto.ToString() + " SON MEJORES!";
                }

            }
            else if (lblRespuesta.Text == "ENVIDO")
            {
                btnEnvido.Visible = false;
                ACCION = "ENVIDO_ENVIDO";
                
                btnEnvido.Visible = false;
            }
            else if (lblRespuesta.Text == "REAL_ENVIDO")
            {
                ACCION = "ENVIDO_REAL_ENVIDO";
                
                btnEnvido.Visible = false;
                btnRealEnvido.Visible = false;
            }
            else if (lblRespuesta.Text == "FALTA_ENVIDO")
            {
                ACCION = "ENVIDO_FALTA_ENVIDO";
                //Lo que le falta al que perdio para llegar a 15

                btnEnvido.Visible = false;
                btnRealEnvido.Visible = false;
                btnFaltaEnvido.Visible = false;
            }
        }


        private void btnQuiero_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = MANO.SuTanto.ToString();
            btnEnvido.Visible = false;
            btnRealEnvido.Visible = false;
            btnFaltaEnvido.Visible = false;
            btnNoQuiero.Visible = false;
            btnQuiero.Visible = false;
            btnMensajeEnvido.Visible = true;
            if ((MANO.SuTanto > MANO.MiTanto) || (MANO.SuTanto == MANO.MiTanto && !MANO.SoyMano))
            {
                btnMensajeEnvido.Text = "SON BUENAS!";
                btnMensajeEnvido.BackColor = Color.Red;
                btnMensajeEnvido.ForeColor = Color.White;
                Tanteador.SusPuntos += PuntosCuandoSeQuiere();
            }
            else
            {
                btnMensajeEnvido.BackColor = Color.LightGreen;
                Tanteador.MisPuntos += PuntosCuandoSeQuiere();
                if (MANO.SuTanto == MANO.MiTanto)
                    btnMensajeEnvido.Text = MANO.MiTanto.ToString() + " DE MANO!";
                else
                    btnMensajeEnvido.Text = MANO.MiTanto.ToString() + " SON MEJORES!";
            }
            
        }

        private void btnNoQuiero_Click(object sender, EventArgs e)
        {
            Tanteador.SusPuntos += PuntosCuandoNoSeQuiere();
                
            this.DialogResult = DialogResult.OK;


        }

        private int PuntosCuandoNoSeQuiere()
        {
            int Aux = 0;

            if (ACCION == "ENVIDO" || ACCION == "REAL_ENVIDO" || ACCION == "FALTA_ENVIDO")
                Aux = 1;
            else if (ACCION == "ENVIDO_ENVIDO" || ACCION == "ENVIDO_REAL_ENVIDO" || ACCION == "ENVIDO_FALTA_ENVIDO")
                Aux = 2;
            else if (ACCION == "REAL_ENVIDO_FALTA_ENVIDO")
                Aux = 3;
            else if (ACCION == "ENVIDO_ENVIDO_REAL_ENVIDO" || ACCION == "ENVIDO_ENVIDO_FALTA_ENVIDO")
                Aux = 4;
            else if (ACCION == "ENVIDO_REAL_ENVIDO_FALTA_ENVIDO") 
                Aux = 5;
            else if (ACCION == "ENVIDO_ENVIDO_REAL_ENVIDO_FALTA_ENVIDO")
                Aux = 7;
            return Aux;
        }

        private int PuntosCuandoSeQuiere()
        {
            int Aux = 0;
            if (ACCION == "ENVIDO") 
                Aux = 2; 
            else if (ACCION == "REAL_ENVIDO") 
                Aux = 3;
            else if (ACCION == "ENVIDO_ENVIDO") 
                Aux = 4; 
            else if (ACCION == "ENVIDO_REAL_ENVIDO") 
                Aux = 5;          
            else if (ACCION == "ENVIDO_ENVIDO_REAL_ENVIDO") 
                Aux = 7;
            else if (ACCION.Contains("FALTA_ENVIDO"))

                Aux = 15;

            return Aux;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnMensajeEnvido_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnRealEnvido_Click(object sender, EventArgs e)
        {
            ACCION = ACCION + "_REAL_ENVIDO";
            AnalizaAccionCuandoSoyMano();
        }

        private void btnFaltaEnvido_Click(object sender, EventArgs e)
        {
            ACCION = ACCION + "_FALTA_ENVIDO";
            AnalizaAccionCuandoSoyMano();
        }

        private void btnEnvido_Click(object sender, EventArgs e)
        {
            ACCION = ACCION + "_ENVIDO";
            AnalizaAccionCuandoSoyMano();
        }
    }
}
