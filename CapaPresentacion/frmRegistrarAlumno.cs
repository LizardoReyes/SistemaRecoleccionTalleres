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
    public partial class frmRegistrarAlumno : Form
    {
        public frmRegistrarAlumno()
        {
            InitializeComponent();
        }

        private void frmRegistrarAlumno_Load(object sender, EventArgs e)
        {
            cboNivelEducativo.Items.Add("Inicial");
            cboNivelEducativo.Items.Add("Primaria");
            cboNivelEducativo.Items.Add("Secundaria");
            cboNivelEducativo.SelectedIndex = 0;
        }
    }
}
