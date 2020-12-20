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
    public partial class frmAgregarMateria : Form
    {
        public frmAgregarMateria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones inputs vacios
            if(txtCodMat.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el codigo de la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodMat.Focus();
                return;
            }
            if (txtNombreMateria.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nombre de la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreMateria.Focus();
                return;
            }
            if (txtNivel.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nivel de la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNivel.Focus();
                return;
            }
            if (txtCarrera.Text.Length == 0)
            {
                MessageBox.Show("Ingresa la carrera de la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarrera.Focus();
                return;
            }

            CapaDatos.Materia materia = new CapaDatos.Materia();
            materia.CodMat = this.txtCodMat.Text;
            materia.NombreMateria = this.txtNombreMateria.Text;
            materia.Nivel = this.txtNivel.Text;
            materia.Carrera = this.txtCarrera.Text;

            int x = CapaDatos.MateriaDAO.crear(materia);
            if (x > 0)
            {
                MessageBox.Show("Registro agregado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el registro");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Validacion solo letras en txtNombreMateria
        private void txtNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validacion solo numeros en txtNivel
        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validacion solo letras en txtCarrera
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void brnNuevo_Click(object sender, EventArgs e)
        {
            this.txtCodMat.Clear();
            this.txtNombreMateria.Clear();
            this.txtNivel.Clear();
            this.txtCarrera.Clear();
        }
    }
}
