using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truco
{
    public partial class fmResultado : Form
    {
        public string Mensaje = "";
        public fmResultado()
        {
            InitializeComponent();
        }

        private void fmResultado_Load(object sender, EventArgs e)
        {
            lblResultado.Text = Mensaje;
        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
