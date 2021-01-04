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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length == 0)
            {
                MessageBox.Show("No hay cédula seleccionada...");
                return;
            }
            CapaDatos.Persona persona = new CapaDatos.Persona();
            persona.Cedula = this.txtCedula.Text;
            persona.Apellidos = this.txtApellidos.Text;
            persona.Nombres = this.txtNombres.Text;
            persona.Sexo = this.txtSexo.Text;
            persona.Correo = this.txtCorreo.Text;
            persona.Peso = decimal.Parse(this.txtEstatura.Text);
            persona.Estatura = int.Parse(this.txtEstatura.Text);
            persona.FechaNacimiento = dtpFechaNacimiento.Value;

            int x = CapaDatos.PersonaDAO.actualizar(persona);

            if (x > 0)
            {
                MessageBox.Show("Registro actualizado con éxito!");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) 
            {
                return;
            }

            int x = CapaDatos.PersonaDAO.eliminar(this.txtCedula.Text);
            if (x > 0)
            {
                this.encerar();
                this.cargarComboEstudiantes();
                MessageBox.Show("Registro eliminado con éxito!");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el registro!");
            }
        }
        private void encerar()
        {
            this.txtCedula.Text = "";
            this.txtApellidos.Text = "";
            this.txtNombres.Text = "";
            this.txtCorreo.Text = "";
            this.txtEstatura.Text = "0";
            this.txtPeso.Text = "0";
            this.txtSexo.Text = "";
        }
    }
}
