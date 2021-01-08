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
    public partial class frmInformeEstudiantes : Form
    {
        public frmInformeEstudiantes()
        {
            InitializeComponent();
        }

        private void frmInformeEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dsEstudiantes.Personas);

            this.reportViewer1.RefreshReport();
        }
    }
}
