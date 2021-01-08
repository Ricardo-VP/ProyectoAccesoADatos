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
    public partial class frmInformeEstudianteMostrar : Form
    {
        private String mCedula;
        public frmInformeEstudianteMostrar(String cedula)
        {
            InitializeComponent();
            mCedula = cedula;
        }

        private void frmInformeEstudianteMostrar_Load(object sender, EventArgs e)
        {
            this.personaXCedulaTableAdapter.FillxCedula(this.dsEstudiantes.PersonaXCedula, mCedula);
            this.reportViewer1.RefreshReport();
        }
    }
}
