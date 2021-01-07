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
    public partial class frmActualizar : Form
    {
        private String mCedula;
        public frmActualizar(String cedula)
        {
            InitializeComponent();
            //El parámetro cédula se recibe como parámetro en el constructor de la clase
            this.mCedula = cedula;
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            this.txtCedula.Text = mCedula;
            CapaDatos.Persona persona = new CapaDatos.Persona();

            persona = CapaDatos.PersonaDAO.GetPersona(mCedula);
            txtApellidos.Text = persona.Apellidos;
            txtNombres.Text = persona.Nombres;
            cmbSex.Text = persona.Sexo;
            txtCorreo.Text = persona.Correo;
            txtEstatura.Text = persona.Estatura.ToString();
            txtPeso.Text = persona.Peso.ToString();
            dtpFechaNacimiento.Value = persona.FechaNacimiento;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(this.mCedula.Length > 0)
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();

                persona.Cedula = mCedula;
                persona.Apellidos = txtApellidos.Text;
                persona.Nombres = txtNombres.Text;
                persona.Sexo = cmbSex.Text;
                persona.Correo = txtCorreo.Text;
                persona.Estatura = int.Parse(txtEstatura.Text);
                persona.Peso = decimal.Parse(txtPeso.Text);
                persona.FechaNacimiento = dtpFechaNacimiento.Value;

                int x = CapaDatos.PersonaDAO.actualizar(persona);

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

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
