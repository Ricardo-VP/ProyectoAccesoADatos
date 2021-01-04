using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmAgregarEstudiante m = new frmAgregarEstudiante();
            m.ShowDialog();
        }

        private void btnFrmListadoEstudiantes_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes m = new frmListadoEstudiantes();
            m.ShowDialog();
        }

        private void btnFrmAgregarMaterias_Click(object sender, EventArgs e)
        {
            frmAgregarMateria m = new frmAgregarMateria();
            m.ShowDialog();
        }

        private void btnFrmListadoMaterias_Click(object sender, EventArgs e)
        {
            frmListadoMaterias m = new frmListadoMaterias();
            m.ShowDialog();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscar m = new frmBuscar();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarMaterias m = new frmBuscarMaterias();
            m.ShowDialog();
        }
    }
}
