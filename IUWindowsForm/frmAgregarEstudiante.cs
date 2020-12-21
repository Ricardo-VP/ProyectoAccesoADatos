using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IUWindowsForm
{
    public partial class frmAgregarEstudiante : Form
    {
        public frmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Llamando función de validación de correo electrónico 
            if (!(ComprobarFormatoEmail(this.txtCorreo.Text)))
            {
                MessageBox.Show("Correo electrónico inválido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return;
            }
            try
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellidos.Text;
                persona.Nombres = this.txtNombres.Text;
                persona.Sexo = this.cmbSex.Text;
                persona.FechaNacimiento = this.dtpFechaNacimiento.Value;
                persona.Correo = this.txtCorreo.Text;
                persona.Estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);

                int x = CapaDatos.PersonaDAO.crear(persona);
                if (x > 0)
                {
                    MessageBox.Show("Registro agregado con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            //Agregar validaciones para inputs vacios

            if(this.txtCedula.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el valor de la cedula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCedula.Focus();
                return;
            }
            if (this.txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Ingresa los apellidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellidos.Focus();
                return;
            }
            if (this.txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingresa los nombres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombres.Focus();
                return;
            }
            if (this.cmbSex.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el sexo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSex.Focus();
                return;
            }
            if (this.txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return;
            }
            if (this.txtEstatura.Text.Length == 0)
            {
                MessageBox.Show("Ingresa la estatura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEstatura.Focus();
                return;
            }
            if (this.txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el peso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPeso.Focus();
                return;
            }


            //Validando combo box vacío de sexo
            if (cmbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el sexo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSex.Focus();
                return;
            }
        }

        //Función para validar email
        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //Validando solo numeros en txtCedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validando solo letras en txtApellidos
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validando solo letras en txtNombre
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validando solo numeros en txtEstatura
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validando solo numeros y decimales en txtPeso
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros enteros y decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permiten un punto decimal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        //Boton para vaciar inputs
        private void brnNuevo_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtApellidos.Clear();
            txtNombres.Clear();
            cmbSex.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtCorreo.Clear();
            txtEstatura.Clear();
            txtPeso.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
