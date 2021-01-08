namespace CapaDatos2.informes
{
    partial class frmInformeMateriaMostrar
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
            this.materiaxCodigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterias = new CapaDatos2.ds.dsMaterias();
            this.materiaxCodigoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.materiaxCodigoTableAdapter = new CapaDatos2.ds.dsMateriasTableAdapters.MateriaxCodigoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materiaxCodigoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaxCodigoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaxCodigoBindingSource
            // 
            this.materiaxCodigoBindingSource.DataMember = "MateriaxCodigo";
            this.materiaxCodigoBindingSource.DataSource = this.dsMaterias;
            // 
            // dsMaterias
            // 
            this.dsMaterias.DataSetName = "dsMaterias";
            this.dsMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaxCodigoBindingSource1
            // 
            this.materiaxCodigoBindingSource1.DataMember = "MateriaxCodigo";
            this.materiaxCodigoBindingSource1.DataSource = this.dsMaterias;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.materiaxCodigoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDatos2.informes.rptMateriaxCodigo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1196, 606);
            this.reportViewer1.TabIndex = 0;
            // 
            // materiaxCodigoTableAdapter
            // 
            this.materiaxCodigoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeMateriaMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeMateriaMostrar";
            this.Text = "Informe de la materia seleccionada";
            this.Load += new System.EventHandler(this.frmInformeMateriaMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaxCodigoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaxCodigoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource materiaxCodigoBindingSource;
        private ds.dsMaterias dsMaterias;
        private ds.dsMateriasTableAdapters.MateriaxCodigoTableAdapter materiaxCodigoTableAdapter;
        private System.Windows.Forms.BindingSource materiaxCodigoBindingSource1;
    }
}