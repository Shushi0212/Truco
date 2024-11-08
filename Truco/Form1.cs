using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arquitectura.Entidades;
using Arquitectura.Negocios;

namespace Truco
{
    public partial class Truco : Form
    {
        private MazoCartas Mazo;
        private Mano mano;

        private Tanteador Tanteador;


        
        public bool SoyMano = true;
        


        public bool EnvidoCantado = true;
        public Truco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mazo = MazoCartasBss.CrearMazodeCartas(Properties.Resources.Baraja_española_completa);
            IniciarPartida();
        }

        private void IniciarPartida()
        {
            Tanteador = new Tanteador();

            ImgJugadorGrupo1.Image = Properties.Resources._0_fw;
            ImgJugadorGrupo2.Image = Properties.Resources._0_fw;
            ImgJugadorGrupo3.Image = Properties.Resources._0_fw;

            ImgComputadoraGrupo1.Image = Properties.Resources._0_fw;
            ImgComputadoraGrupo2.Image = Properties.Resources._0_fw;
            ImgComputadoraGrupo3.Image = Properties.Resources._0_fw;

            labelMIO.Text = "";
            labelSUS.Text = "";
            
            Repartir();
        }

        private void Repartir()
        {

            EnvidoCantado = false;
            BtnEnvidoEnEstaMano();

            mano = MazoCartasBss.Repartir(Mazo);
            mano.SoyMano = SoyMano;

            btnMisCartasCarta1.Image = mano.MisTresCartas[0].imagen;
            btnMisCartasCarta2.Image = mano.MisTresCartas[1].imagen;
            btnMisCartasCarta3.Image = mano.MisTresCartas[2].imagen;

            SoyMano = !SoyMano;

            

            if (!mano.SoyMano)
            {
                //Juega la computadora
                //Criterio del Envido;

                pnlOperaciones.Enabled = false;

                string ACCION = ComputadoraBss.CriterioParaCantarTanto(mano);
                if (ACCION != String.Empty)
                {

                    btnEnvido.Visible = false;
                    btnRealEnvido.Visible = false;
                    btnFaltaEnvido.Visible = false; 

                    FmDialogo fm = new FmDialogo();
                    fm.ACCION = ACCION;
                    fm.MANO = mano;
                    fm.Tanteador = Tanteador;
                    fm.CantaJugador = false;

                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        RefrescaTanteador();
                    }
                }

                pnlOperaciones.Enabled = true;
            }
            

        }

        

        private void BtnEnvidoEnEstaMano()
        {
            
            btnEnvido.Visible = !EnvidoCantado;
            btnFaltaEnvido.Visible = !EnvidoCantado;
            btnRealEnvido.Visible = !EnvidoCantado;
        }

        private void btnVoyAlMazo_Click(object sender, EventArgs e)
        {
            if (btnEnvido.Visible)
                Tanteador.SusPuntos += 2;
            else
                Tanteador.SusPuntos += 1;
            RefrescaTanteador();
            Repartir();
            
        }

        private void btnMisCartasCarta1_Click(object sender, EventArgs e)
        {
            btnMisMesaCarta1.Image = btnMisCartasCarta1.Image;
            btnMisCartasCarta1.Visible = false;
        }

        private void btnEnvido_Click(object sender, EventArgs e)
        {

            EnvidoCantado = true;
            BtnEnvidoEnEstaMano();
            
            FmDialogo fm = new FmDialogo();
            fm.ACCION = "ENVIDO";
            fm.MANO = mano;
            fm.Tanteador = Tanteador;
            fm.CantaJugador = true;

            if (fm.ShowDialog() == DialogResult.OK) {
                RefrescaTanteador();
            }
        }

        public void btnRealEnvido_Click(object sender, EventArgs e)
        {
            FmDialogo fm = new FmDialogo();
            fm.ACCION = "REAL_ENVIDO";
            fm.Tanteador = Tanteador;
            fm.CantaJugador = true;
            fm.MANO = mano;
            if (fm.ShowDialog() == DialogResult.OK)
            {
                RefrescaTanteador();
            }
        }

        private Image DevuelveImagenMenor5(int Puntos)
        {
            if (Puntos == 1)
            {
                return Properties.Resources._1_fw;
            }
            else if (Puntos == 2)
            {
                return Properties.Resources._2_fw;
            }
            else if (Puntos == 3)
            {
                return Properties.Resources._3_fw;
            }
            else if (Puntos == 4)
            {
                return Properties.Resources._4_fw;
            }
            else if (Puntos == 5)
            {
                return Properties.Resources._5_fw;
            }

            
                return Properties.Resources._0_fw;
            
        }

        private void RefrescaTanteador()
        {
            if (Tanteador.MisPuntos >= 15 || Tanteador.SusPuntos >= 15)
            {
                string Texto = "PERDISTE!";
                if (Tanteador.MisPuntos >= 15)
                    Texto = "GANASTE!";

                fmResultado fm = new fmResultado();
                fm.Text = Texto;
                fm.Mensaje = Texto;


                if (fm.ShowDialog() == DialogResult.OK)
                {
                    IniciarPartida();
                }
            
            }
            else
            {
                labelMIO.Text = Tanteador.MisPuntos.ToString();
                labelSUS.Text = Tanteador.SusPuntos.ToString();

                int Aux = 0;

                if (Tanteador.MisPuntos > 0 && Tanteador.MisPuntos <= 5)
                {

                    ImgJugadorGrupo1.Image = DevuelveImagenMenor5(Tanteador.MisPuntos);
                }
                else if (Tanteador.MisPuntos > 5 && Tanteador.MisPuntos <= 10)
                {

                    ImgJugadorGrupo1.Image = Properties.Resources._5_fw;

                    Aux = Tanteador.MisPuntos - 5;
                    ImgJugadorGrupo2.Image = DevuelveImagenMenor5(Aux);
                }
                else if (Tanteador.MisPuntos > 10 && Tanteador.MisPuntos <= 15)
                {
                    ImgJugadorGrupo1.Image = Properties.Resources._5_fw;
                    ImgJugadorGrupo2.Image = Properties.Resources._5_fw;

                    Aux = Tanteador.MisPuntos - 10;

                    ImgJugadorGrupo3.Image = DevuelveImagenMenor5(Aux);

                }


                if (Tanteador.SusPuntos > 0 && Tanteador.SusPuntos <= 5)
                {

                    ImgComputadoraGrupo1.Image = DevuelveImagenMenor5(Tanteador.SusPuntos);
                }
                else if (Tanteador.SusPuntos > 5 && Tanteador.SusPuntos <= 10)
                {

                    ImgComputadoraGrupo1.Image = Properties.Resources._5_fw;

                    Aux = Tanteador.SusPuntos - 5;
                    ImgComputadoraGrupo2.Image = DevuelveImagenMenor5(Aux);
                }
                else if (Tanteador.SusPuntos > 10 && Tanteador.SusPuntos <= 15)
                {
                    ImgComputadoraGrupo1.Image = Properties.Resources._5_fw;
                    ImgComputadoraGrupo2.Image = Properties.Resources._5_fw;

                    Aux = Tanteador.SusPuntos - 10;

                    ImgComputadoraGrupo3.Image = DevuelveImagenMenor5(Aux);

                }
            }
        }

        private void btnFaltaEnvido_Click(object sender, EventArgs e)
        {
            FmDialogo fm = new FmDialogo();
            fm.ACCION = "FALTA_ENVIDO";
            fm.Tanteador = Tanteador;
            fm.CantaJugador = true;
            fm.MANO = mano;
            if (fm.ShowDialog() == DialogResult.OK)
            {
                RefrescaTanteador();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
