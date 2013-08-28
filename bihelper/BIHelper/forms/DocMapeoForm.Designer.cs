namespace BIHelper.forms
{
    partial class DocMapeoForm
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
            this.ETLDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.ExplorarArchivoXmlIPCButton = new Dotnetrix.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MapeosComboBox = new System.Windows.Forms.ComboBox();
            this.GenerarDocumentacionButton = new Dotnetrix.CustomButton();
            this.DocumentadorReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ETLDocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ETLDocBindingSource
            // 
            this.ETLDocBindingSource.DataSource = typeof(BIHelper.lib.ETLDoc);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el archivo *.xml exportado de Informatica PC:";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(405, 10);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(499, 27);
            this.FileNameTextBox.TabIndex = 0;
            this.FileNameTextBox.TabStop = false;
            // 
            // ExplorarArchivoXmlIPCButton
            // 
            this.ExplorarArchivoXmlIPCButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExplorarArchivoXmlIPCButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExplorarArchivoXmlIPCButton.ForeColor = System.Drawing.Color.White;
            this.ExplorarArchivoXmlIPCButton.Location = new System.Drawing.Point(910, 10);
            this.ExplorarArchivoXmlIPCButton.Name = "ExplorarArchivoXmlIPCButton";
            this.ExplorarArchivoXmlIPCButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.ExplorarArchivoXmlIPCButton.Size = new System.Drawing.Size(56, 27);
            this.ExplorarArchivoXmlIPCButton.TabIndex = 1;
            this.ExplorarArchivoXmlIPCButton.Text = "...";
            this.ExplorarArchivoXmlIPCButton.UseVisualStyleBackColor = true;
            this.ExplorarArchivoXmlIPCButton.Click += new System.EventHandler(this.ExplorarArchivoXmlIPCButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione el mapeo a documentar:";
            // 
            // MapeosComboBox
            // 
            this.MapeosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapeosComboBox.FormattingEnabled = true;
            this.MapeosComboBox.Location = new System.Drawing.Point(278, 46);
            this.MapeosComboBox.Name = "MapeosComboBox";
            this.MapeosComboBox.Size = new System.Drawing.Size(501, 28);
            this.MapeosComboBox.TabIndex = 2;
            // 
            // GenerarDocumentacionButton
            // 
            this.GenerarDocumentacionButton.BackColor = System.Drawing.Color.Firebrick;
            this.GenerarDocumentacionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GenerarDocumentacionButton.ForeColor = System.Drawing.Color.White;
            this.GenerarDocumentacionButton.Location = new System.Drawing.Point(785, 46);
            this.GenerarDocumentacionButton.Name = "GenerarDocumentacionButton";
            this.GenerarDocumentacionButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.GenerarDocumentacionButton.Size = new System.Drawing.Size(181, 28);
            this.GenerarDocumentacionButton.TabIndex = 3;
            this.GenerarDocumentacionButton.Text = "Generar Documento";
            this.GenerarDocumentacionButton.UseVisualStyleBackColor = true;
            this.GenerarDocumentacionButton.Click += new System.EventHandler(this.GenerarDocumentacionButton_Click);
            // 
            // DocumentadorReportViewer
            // 
            reportDataSource1.Name = "ETLDoc_DataSet";
            reportDataSource1.Value = this.ETLDocBindingSource;
            this.DocumentadorReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.DocumentadorReportViewer.LocalReport.ReportEmbeddedResource = "BIHelper.reports.DocumentacionMapeoReport.rdlc";
            this.DocumentadorReportViewer.Location = new System.Drawing.Point(20, 80);
            this.DocumentadorReportViewer.Name = "DocumentadorReportViewer";
            this.DocumentadorReportViewer.Size = new System.Drawing.Size(946, 477);
            this.DocumentadorReportViewer.TabIndex = 7;
            this.DocumentadorReportViewer.TabStop = false;
            // 
            // DocMapeoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.DocumentadorReportViewer);
            this.Controls.Add(this.GenerarDocumentacionButton);
            this.Controls.Add(this.MapeosComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExplorarArchivoXmlIPCButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "DocMapeoForm";
            this.Text = "DocMapeoForm";
            ((System.ComponentModel.ISupportInitialize)(this.ETLDocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private Dotnetrix.CustomButton ExplorarArchivoXmlIPCButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MapeosComboBox;
        private Dotnetrix.CustomButton GenerarDocumentacionButton;
        private Microsoft.Reporting.WinForms.ReportViewer DocumentadorReportViewer;
        private System.Windows.Forms.BindingSource ETLDocBindingSource;
    }
}