namespace IUWindowsForm
{
    partial class frmAgregarMateria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.brnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtCodMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNivelMateria = new System.Windows.Forms.Label();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblCodMateria = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.brnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNivel);
            this.groupBox1.Controls.Add(this.txtNombreMateria);
            this.groupBox1.Controls.Add(this.txtCodMat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNivelMateria);
            this.groupBox1.Controls.Add(this.lblNombreMateria);
            this.groupBox1.Controls.Add(this.lblCodMateria);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos de la materia";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(327, 253);
            this.txtCarrera.MaxLength = 50;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(307, 30);
            this.txtCarrera.TabIndex = 22;
            this.txtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnNuevo
            // 
            this.brnNuevo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.brnNuevo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnNuevo.Location = new System.Drawing.Point(763, 127);
            this.brnNuevo.Name = "brnNuevo";
            this.brnNuevo.Size = new System.Drawing.Size(139, 48);
            this.brnNuevo.TabIndex = 19;
            this.brnNuevo.Text = "Nuevo";
            this.brnNuevo.UseVisualStyleBackColor = false;
            this.brnNuevo.Click += new System.EventHandler(this.brnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(763, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 48);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(327, 188);
            this.txtNivel.MaxLength = 1;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(183, 30);
            this.txtNivel.TabIndex = 10;
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMateria.Location = new System.Drawing.Point(327, 127);
            this.txtNombreMateria.MaxLength = 50;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(307, 30);
            this.txtNombreMateria.TabIndex = 9;
            this.txtNombreMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMateria_KeyPress);
            // 
            // txtCodMat
            // 
            this.txtCodMat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMat.Location = new System.Drawing.Point(327, 74);
            this.txtCodMat.MaxLength = 10;
            this.txtCodMat.Name = "txtCodMat";
            this.txtCodMat.Size = new System.Drawing.Size(307, 30);
            this.txtCodMat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNivelMateria
            // 
            this.lblNivelMateria.AutoSize = true;
            this.lblNivelMateria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelMateria.Location = new System.Drawing.Point(102, 191);
            this.lblNivelMateria.Name = "lblNivelMateria";
            this.lblNivelMateria.Size = new System.Drawing.Size(46, 24);
            this.lblNivelMateria.TabIndex = 2;
            this.lblNivelMateria.Text = "Nivel";
            this.lblNivelMateria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(102, 127);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(69, 24);
            this.lblNombreMateria.TabIndex = 1;
            this.lblNombreMateria.Text = "Nombre";
            // 
            // lblCodMateria
            // 
            this.lblCodMateria.AutoSize = true;
            this.lblCodMateria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMateria.Location = new System.Drawing.Point(102, 74);
            this.lblCodMateria.Name = "lblCodMateria";
            this.lblCodMateria.Size = new System.Drawing.Size(144, 24);
            this.lblCodMateria.TabIndex = 0;
            this.lblCodMateria.Text = "Codigo de materia";
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregarMateria";
            this.Text = "Agregar Materia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtCodMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNivelMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.Label lblCodMateria;
        private System.Windows.Forms.TextBox txtCarrera;
    }
}