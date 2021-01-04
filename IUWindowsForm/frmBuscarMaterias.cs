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
    public partial class frmBuscarMaterias : Form
    {
        public frmBuscarMaterias()
        {
            InitializeComponent();
        }
        private void cargarComboMaterias()
        {
            this.cmbCodigoMateria.DataSource = CapaDatos.MateriaDAO.GetAll();
            this.cmbCodigoMateria.DisplayMember = "materia";
            this.cmbCodigoMateria.ValueMember = "codMat";
        }

        private void btnActualizarMateria_Click(object sender, EventArgs e)
        {
            if (this.txtCodMat.Text.Length == 0)
            {
                MessageBox.Show("No hay código de materia seleccionado...");
                return;
            }
            CapaDatos.Materia materia = new CapaDatos.Materia();
            materia.CodMat = this.txtCodMat.Text;
            materia.NombreMateria = this.txtNombreMateria.Text;
            materia.Nivel = this.txtNivel.Text;
            materia.Carrera = this.txtCarrera.Text;

            int x = CapaDatos.MateriaDAO.actualizar(materia);
            if (x > 0)
            {
                MessageBox.Show("Registro actualizado con éxito!");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro");
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }

            int x = CapaDatos.MateriaDAO.eliminar(this.txtCodMat.Text);
            if (x > 0)
            {
                this.encerar();
                this.cargarComboMaterias();
                MessageBox.Show("Registro eliminado con éxito!");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el registro!");
            }
        }
        private void encerar()
        {
            this.txtCodMat.Text = "";
            this.txtNombreMateria.Text = "";
            this.txtNivel.Text = "";
            this.txtCarrera.Text = "";
        }

        private void frmBuscarMaterias_Load(object sender, EventArgs e)
        {
            this.cargarComboMaterias();
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            string codMat = this.cmbCodigoMateria.SelectedValue.ToString();
            CapaDatos.Materia m = new CapaDatos.Materia();
            m = CapaDatos.MateriaDAO.GetMateria(codMat);

            //cargar datos en los cuadros de texto
            this.txtCodMat.Text = m.CodMat;
            this.txtNombreMateria.Text = m.NombreMateria;
            this.txtNivel.Text = m.Nivel;
            this.txtCarrera.Text = m.Carrera;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
