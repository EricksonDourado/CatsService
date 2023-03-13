using CatsService.Controllers;
using CatsService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsService
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeusFavoritos frmMeusFavoritos = new FrmMeusFavoritos();
            frmMeusFavoritos.Show();
        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarRacas frmBuscarRacas = new FrmBuscarRacas();
            //frmBuscarRacas.MdiParent = this;
            frmBuscarRacas.Show();
        }
    }
}
