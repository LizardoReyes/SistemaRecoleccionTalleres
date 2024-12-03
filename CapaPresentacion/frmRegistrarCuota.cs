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
    public partial class frmRegistrarCuota : Form
    {
        private int cuotaBase = 880;

        public frmRegistrarCuota()
        {
            InitializeComponent();
        }

        private void frmRegistrarCuota_Load(object sender, EventArgs e)
        {
        }

        private void cboNivelEducativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cboNivelEducativo1 = 0;
            switch(cboNivelEducativo1)
            {
                case 0:
                    txtCuotaMensual.Text = "S/ " + (cuotaBase*1).ToString();
                    break;
                case 1:
                    txtCuotaMensual.Text = "S/ " + (cuotaBase * 1.15).ToString();
                    break;
                case 2:
                    txtCuotaMensual.Text = "S/ " + (cuotaBase * 1.3).ToString();
                    break;
            }
        }
    }
}
