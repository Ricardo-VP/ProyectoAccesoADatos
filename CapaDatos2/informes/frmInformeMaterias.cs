using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos2.informes
{
    public partial class frmInformeMaterias : Form
    {
        public frmInformeMaterias()
        {
            InitializeComponent();
        }

        private void frmInformeMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMaterias.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.FillMaterias(this.dsMaterias.Materias);

            this.reportViewer1.RefreshReport();
        }
    }
}
