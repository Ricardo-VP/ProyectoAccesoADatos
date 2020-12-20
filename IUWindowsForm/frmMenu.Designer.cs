namespace IUWindowsForm
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFrmAEstudiantes = new System.Windows.Forms.Button();
            this.btnFrmAgregarMaterias = new System.Windows.Forms.Button();
            this.btnFrmListadoEstudiantes = new System.Windows.Forms.Button();
            this.btnFrmListadoMaterias = new System.Windows.Forms.Button();
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFrmAEstudiantes
            // 
            this.btnFrmAEstudiantes.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFrmAEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmAEstudiantes.Location = new System.Drawing.Point(114, 143);
            this.btnFrmAEstudiantes.Name = "btnFrmAEstudiantes";
            this.btnFrmAEstudiantes.Size = new System.Drawing.Size(228, 48);
            this.btnFrmAEstudiantes.TabIndex = 19;
            this.btnFrmAEstudiantes.Text = "Agregar estudiantes";
            this.btnFrmAEstudiantes.UseVisualStyleBackColor = false;
            this.btnFrmAEstudiantes.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFrmAgregarMaterias
            // 
            this.btnFrmAgregarMaterias.BackColor = System.Drawing.Color.Yellow;
            this.btnFrmAgregarMaterias.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmAgregarMaterias.Location = new System.Drawing.Point(114, 301);
            this.btnFrmAgregarMaterias.Name = "btnFrmAgregarMaterias";
            this.btnFrmAgregarMaterias.Size = new System.Drawing.Size(228, 48);
            this.btnFrmAgregarMaterias.TabIndex = 20;
            this.btnFrmAgregarMaterias.Text = "Agregar materias";
            this.btnFrmAgregarMaterias.UseVisualStyleBackColor = false;
            this.btnFrmAgregarMaterias.Click += new System.EventHandler(this.btnFrmAgregarMaterias_Click);
            // 
            // btnFrmListadoEstudiantes
            // 
            this.btnFrmListadoEstudiantes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFrmListadoEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmListadoEstudiantes.Location = new System.Drawing.Point(114, 197);
            this.btnFrmListadoEstudiantes.Name = "btnFrmListadoEstudiantes";
            this.btnFrmListadoEstudiantes.Size = new System.Drawing.Size(228, 48);
            this.btnFrmListadoEstudiantes.TabIndex = 21;
            this.btnFrmListadoEstudiantes.Text = "Listado estudiantes";
            this.btnFrmListadoEstudiantes.UseVisualStyleBackColor = false;
            this.btnFrmListadoEstudiantes.Click += new System.EventHandler(this.btnFrmListadoEstudiantes_Click);
            // 
            // btnFrmListadoMaterias
            // 
            this.btnFrmListadoMaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFrmListadoMaterias.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmListadoMaterias.Location = new System.Drawing.Point(114, 355);
            this.btnFrmListadoMaterias.Name = "btnFrmListadoMaterias";
            this.btnFrmListadoMaterias.Size = new System.Drawing.Size(228, 48);
            this.btnFrmListadoMaterias.TabIndex = 22;
            this.btnFrmListadoMaterias.Text = "Listado materias";
            this.btnFrmListadoMaterias.UseVisualStyleBackColor = false;
            this.btnFrmListadoMaterias.Click += new System.EventHandler(this.btnFrmListadoMaterias_Click);
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarForm.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarForm.Location = new System.Drawing.Point(114, 507);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(228, 48);
            this.btnCerrarForm.TabIndex = 23;
            this.btnCerrarForm.Text = "Cerrar";
            this.btnCerrarForm.UseVisualStyleBackColor = false;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Menu de navegación";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarForm);
            this.Controls.Add(this.btnFrmListadoMaterias);
            this.Controls.Add(this.btnFrmListadoEstudiantes);
            this.Controls.Add(this.btnFrmAgregarMaterias);
            this.Controls.Add(this.btnFrmAEstudiantes);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmAEstudiantes;
        private System.Windows.Forms.Button btnFrmAgregarMaterias;
        private System.Windows.Forms.Button btnFrmListadoEstudiantes;
        private System.Windows.Forms.Button btnFrmListadoMaterias;
        private System.Windows.Forms.Button btnCerrarForm;
        private System.Windows.Forms.Label label1;
    }
}