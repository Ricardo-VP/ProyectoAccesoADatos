namespace CapaDatos2.informes
{
    partial class frmInformeEstudianteMostrar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.personaXCedulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiantes = new CapaDatos2.ds.dsEstudiantes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personaXCedulaTableAdapter = new CapaDatos2.ds.dsEstudiantesTableAdapters.PersonaXCedulaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personaXCedulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // personaXCedulaBindingSource
            // 
            this.personaXCedulaBindingSource.DataMember = "PersonaXCedula";
            this.personaXCedulaBindingSource.DataSource = this.dsEstudiantes;
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personaXCedulaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDatos2.informes.rptEstudiantexCedula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1280, 640);
            this.reportViewer1.TabIndex = 0;
            // 
            // personaXCedulaTableAdapter
            // 
            this.personaXCedulaTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeEstudianteMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 640);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInformeEstudianteMostrar";
            this.Text = "Mostrar informe del estudiante";
            this.Load += new System.EventHandler(this.frmInformeEstudianteMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaXCedulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personaXCedulaBindingSource;
        private ds.dsEstudiantes dsEstudiantes;
        private ds.dsEstudiantesTableAdapters.PersonaXCedulaTableAdapter personaXCedulaTableAdapter;
    }
}