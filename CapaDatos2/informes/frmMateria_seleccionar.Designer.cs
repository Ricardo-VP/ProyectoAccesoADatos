namespace CapaDatos2.informes
{
    partial class frmMateria_seleccionar
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(456, 130);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(159, 53);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.Text = "Volver";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.LawnGreen;
            this.btnInforme.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(174, 131);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(159, 52);
            this.btnInforme.TabIndex = 39;
            this.btnInforme.Text = "Ver informe";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMateria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMateria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(334, 38);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(345, 32);
            this.cmbMateria.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Seleccione la materia";
            // 
            // frmMateria_seleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 230);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label1);
            this.Name = "frmMateria_seleccionar";
            this.Text = "Selección de materia";
            this.Load += new System.EventHandler(this.frmMateria_seleccionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label1;
    }
}