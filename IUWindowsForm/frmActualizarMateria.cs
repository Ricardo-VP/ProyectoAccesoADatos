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
    public partial class frmActualizarMateria : Form
    {
        private string Materia;
        public frmActualizarMateria(String nombreMateria)
        {
            InitializeComponent();
            this.Materia = nombreMateria;
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if(this.Materia.Length > 0)
            {
                CapaDatos.Materia materia = new CapaDatos.Materia();

                materia.CodMat = txtCodMat.Text;
                materia.NombreMateria = txtNombreMateria.Text;
                materia.Carrera = txtCarrera.Text;
                materia.Nivel = txtNivel.Text;

                int x = CapaDatos.MateriaDAO.actualizar(materia);

                if (x > 0)
                {
                    MessageBox.Show("Registro actualziado!");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
            }
        }

        private void frmActualizarMateria_Load(object sender, EventArgs e)
        {
            
            CapaDatos.Materia materia = new CapaDatos.Materia();
            materia = CapaDatos.MateriaDAO.GetMateria(Materia);

            txtCodMat.Text = materia.CodMat;
            txtNombreMateria.Text = Materia;
            txtCarrera.Text = materia.Carrera;
            txtNivel.Text = materia.Nivel;
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
