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

        private void frmListadoMaterias_Load(object sender, EventArgs e)
        {

        }

        private void cargarGrid()
        {
            this.dataGridViewMaterias.Refresh();
            this.dataGridViewMaterias.DataSource = CapaDatos.MateriaDAO.GetAll();
        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar si se hizo click en el link eliminar 
            if (this.dataGridViewMaterias.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                //Recuperar cédula de la fila actual
                int fila = e.RowIndex;
                String codMat = dataGridViewMaterias["Código", fila].Value.ToString();
                String materia = dataGridViewMaterias["Materia", fila].Value.ToString();

                DialogResult dr = MessageBox.Show("¿Está segur@ que desea eliminar la materia " + materia + " ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }

                int x = CapaDatos.MateriaDAO.eliminar(codMat);

                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con éxito!");
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el registro..");
                }

            }
            else if (this.dataGridViewMaterias.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                int fila = e.RowIndex;
                String Materia = dataGridViewMaterias["Materia", fila].Value.ToString();
                frmActualizarMateria frm1 = new frmActualizarMateria(Materia);
                frm1.ShowDialog();
                cargarGrid();
            }
        }


    }
}
