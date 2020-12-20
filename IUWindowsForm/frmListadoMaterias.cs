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
    public partial class frmListadoMaterias : Form
    {
        public frmListadoMaterias()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.dataGridViewMaterias.DataSource = CapaDatos.MateriaDAO.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
