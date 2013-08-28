namespace BIHelper.forms
{
    partial class AnalisisCuboForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.ServidorArtusComboBox = new System.Windows.Forms.ComboBox();
            this.conexionMetaDataArtusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CuboComboBox = new System.Windows.Forms.ComboBox();
            this.sI_CONCEPTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenerarDocumentacionButton = new Dotnetrix.CustomButton();
            this.ReporteCuboReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.conexionMetaDataArtusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_CONCEPTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un servidor Artus:";
            // 
            // ServidorArtusComboBox
            // 
            this.ServidorArtusComboBox.DataSource = this.conexionMetaDataArtusBindingSource;
            this.ServidorArtusComboBox.DisplayMember = "Nombre";
            this.ServidorArtusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServidorArtusComboBox.FormattingEnabled = true;
            this.ServidorArtusComboBox.Location = new System.Drawing.Point(217, 10);
            this.ServidorArtusComboBox.Name = "ServidorArtusComboBox";
            this.ServidorArtusComboBox.Size = new System.Drawing.Size(385, 28);
            this.ServidorArtusComboBox.TabIndex = 1;
            this.ServidorArtusComboBox.ValueMember = "Nombre";
            this.ServidorArtusComboBox.SelectionChangeCommitted += new System.EventHandler(this.ServidorArtusComboBox_SelectionChangeCommitted);
            // 
            // conexionMetaDataArtusBindingSource
            // 
            this.conexionMetaDataArtusBindingSource.DataSource = typeof(BIHelper.lib.ConexionMetaDataArtus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione un cubo:";
            // 
            // CuboComboBox
            // 
            this.CuboComboBox.DataSource = this.sI_CONCEPTOBindingSource;
            this.CuboComboBox.DisplayMember = "NOM_CONCEPTO";
            this.CuboComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CuboComboBox.FormattingEnabled = true;
            this.CuboComboBox.Location = new System.Drawing.Point(217, 45);
            this.CuboComboBox.Name = "CuboComboBox";
            this.CuboComboBox.Size = new System.Drawing.Size(385, 28);
            this.CuboComboBox.TabIndex = 3;
            this.CuboComboBox.ValueMember = "CLA_CONCEPTO";
            // 
            // sI_CONCEPTOBindingSource
            // 
            this.sI_CONCEPTOBindingSource.DataSource = typeof(BIHelper.lib.artus.SI_CONCEPTO);
            // 
            // GenerarDocumentacionButton
            // 
            this.GenerarDocumentacionButton.BackColor = System.Drawing.Color.Firebrick;
            this.GenerarDocumentacionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GenerarDocumentacionButton.ForeColor = System.Drawing.Color.White;
            this.GenerarDocumentacionButton.Location = new System.Drawing.Point(625, 18);
            this.GenerarDocumentacionButton.Name = "GenerarDocumentacionButton";
            this.GenerarDocumentacionButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.GenerarDocumentacionButton.Size = new System.Drawing.Size(263, 43);
            this.GenerarDocumentacionButton.TabIndex = 4;
            this.GenerarDocumentacionButton.Text = "Generar Reporte";
            this.GenerarDocumentacionButton.UseVisualStyleBackColor = true;
            this.GenerarDocumentacionButton.Click += new System.EventHandler(this.GenerarDocumentacionButton_Click);
            // 
            // ReporteCuboReportViewer
            // 
            reportDataSource1.Name = "SI_CONCEPTO_DataSet";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "Vista_Dimensiones_DataSet";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "Vista_Indicadores_DataSet";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "Vista_Periodos_DataSet";
            reportDataSource4.Value = null;
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.ReporteCuboReportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.ReporteCuboReportViewer.LocalReport.ReportEmbeddedResource = "BIHelper.reports.DetalleCuboReport.rdlc";
            this.ReporteCuboReportViewer.Location = new System.Drawing.Point(12, 90);
            this.ReporteCuboReportViewer.Name = "ReporteCuboReportViewer";
            this.ReporteCuboReportViewer.Size = new System.Drawing.Size(996, 467);
            this.ReporteCuboReportViewer.TabIndex = 5;
            // 
            // AnalisisCuboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.ReporteCuboReportViewer);
            this.Controls.Add(this.GenerarDocumentacionButton);
            this.Controls.Add(this.CuboComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServidorArtusComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AnalisisCuboForm";
            this.Text = "AnalisisCuboForm";
            this.Load += new System.EventHandler(this.AnalisisCuboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conexionMetaDataArtusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_CONCEPTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServidorArtusComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CuboComboBox;
        private Dotnetrix.CustomButton GenerarDocumentacionButton;
        private Microsoft.Reporting.WinForms.ReportViewer ReporteCuboReportViewer;
        private System.Windows.Forms.BindingSource conexionMetaDataArtusBindingSource;
        private System.Windows.Forms.BindingSource sI_CONCEPTOBindingSource;
    }
}