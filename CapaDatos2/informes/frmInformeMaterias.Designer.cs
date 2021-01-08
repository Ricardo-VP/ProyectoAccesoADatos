namespace CapaDatos2.informes
{
    partial class frmInformeMaterias
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
            this.dsMaterias = new CapaDatos2.ds.dsMaterias();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new CapaDatos2.ds.dsMateriasTableAdapters.MateriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.materiasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDatos2.informes.rptMaterias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1094, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsMaterias
            // 
            this.dsMaterias.DataSetName = "dsMaterias";
            this.dsMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "Materias";
            this.materiasBindingSource.DataSource = this.dsMaterias;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 503);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeMaterias";
            this.Text = "frmInformeMaterias";
            this.Load += new System.EventHandler(this.frmInformeMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsMaterias dsMaterias;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private ds.dsMateriasTableAdapters.MateriasTableAdapter materiasTableAdapter;
    }
}