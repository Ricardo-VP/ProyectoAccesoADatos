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
    public partial class frmEstudiante_seleccionar : Form
    {
        public frmEstudiante_seleccionar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEstudiante_seleccionar_Load(object sender, EventArgs e)
        {
            cargarComboEstudiantes();
        }
        private void cargarComboEstudiantes()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.GetAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "Cédula";
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            informes.frmInformeEstudianteMostrar frm1 = new informes.frmInformeEstudianteMostrar(this.cmbCedula.SelectedValue.ToString());
            frm1.ShowDialog();
        }
    }
}
