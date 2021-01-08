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
    public partial class frmMateria_seleccionar : Form
    {
        public frmMateria_seleccionar()
        {
            InitializeComponent();
        }

        private void frmMateria_seleccionar_Load(object sender, EventArgs e)
        {
            cargarComboMaterias();
        }
        private void cargarComboMaterias()
        {
            this.cmbMateria.DataSource = CapaDatos.MateriaDAO.GetAll();
            this.cmbMateria.DisplayMember = "materia";
            this.cmbMateria.ValueMember = "Materia";
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            informes.frmInformeMateriaMostrar frm1 = new informes.frmInformeMateriaMostrar(this.cmbMateria.SelectedValue.ToString());
            frm1.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
