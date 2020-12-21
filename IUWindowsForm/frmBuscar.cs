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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            //Evento load: Se ejecuta cada vez que se carga el formulario
            this.cargarComboEstudiantes();
        }

        private void cargarComboEstudiantes()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.GetAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "Cédula";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula = this.cmbCedula.SelectedValue.ToString();
            CapaDatos.Persona p = new CapaDatos.Persona();
            p = CapaDatos.PersonaDAO.GetPersona(cedula);

            //cargar datos en los cuadros de texto
            this.txtCedula.Text = p.Cedula;
            this.txtApellidos.Text = p.Apellidos;
            this.txtNombres.Text = p.Nombres;
            this.txtSexo.Text = p.Sexo;
            this.txtCorreo.Text = p.Correo;
            this.txtEstatura.Text = p.Estatura.ToString();
            this.txtPeso.Text = p.Peso.ToString();
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Value = p.FechaNacimiento;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
