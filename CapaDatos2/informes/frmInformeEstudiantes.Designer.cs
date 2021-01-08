namespace CapaDatos2.informes
{
    partial class frmInformeEstudiantes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEstudiantes = new CapaDatos2.ds.dsEstudiantes();
            this.dsEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new CapaDatos2.ds.dsEstudiantesTableAdapters.PersonasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDatos2.informes.rptEstudiantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(895, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEstudiantesBindingSource
            // 
            this.dsEstudiantesBindingSource.DataSource = this.dsEstudiantes;
            this.dsEstudiantesBindingSource.Position = 0;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.dsEstudiantes;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 484);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeEstudiantes";
            this.Text = "frmInformeEstudiantes";
            this.Load += new System.EventHandler(this.frmInformeEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsEstudiantesBindingSource;
        private ds.dsEstudiantes dsEstudiantes;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private ds.dsEstudiantesTableAdapters.PersonasTableAdapter personasTableAdapter;
    }
}