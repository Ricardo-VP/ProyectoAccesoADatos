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
    public partial class frmListadoEstudiantes : Form
    {
        public frmListadoEstudiantes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarGrid()
        {
            this.dataGridViewEstudiantes.Refresh();
            this.dataGridViewEstudiantes.DataSource = CapaDatos.PersonaDAO.GetAll();
        }

        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar si se hizo click en el link eliminar 
            if (this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                //Recuperar cédula de la fila actual
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["Cédula", fila].Value.ToString();
                String estudiante = dataGridViewEstudiantes["Estudiante", fila].Value.ToString();

                DialogResult dr = MessageBox.Show("¿Está segur@ que desea eliminar al estudiante " + estudiante + " ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dr == DialogResult.No)
                {
                    return;
                }

                int x = CapaDatos.PersonaDAO.eliminar(cedula);

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
            else if (this.dataGridViewEstudiantes.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                int fila = e.RowIndex;
                String cedula = dataGridViewEstudiantes["Cédula", fila].Value.ToString();
                frmActualizar frm1 = new frmActualizar(cedula);
                frm1.ShowDialog();
                cargarGrid();
            }
        }

        private void frmListadoEstudiantes_Load(object sender, EventArgs e)
        {
           
        }
    }
}
