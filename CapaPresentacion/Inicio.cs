using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void menuRegistrarCuota_Click(object sender, EventArgs e)
        {
            frmRegistrarCuota frm = new frmRegistrarCuota();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarAlumno frm = new frmRegistrarAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarAlumnos frm = new frmListarAlumnos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListarCuotas frm = new frmListarCuotas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarTaller frm = new frmRegistrarTaller();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListarTalleres frm = new frmListarTalleres();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
