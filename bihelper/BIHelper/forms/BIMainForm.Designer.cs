namespace BIHelper.forms
{
    partial class BIMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIMainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.HerramientasFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AyudaButton = new Dotnetrix.CustomButton();
            this.ConexionesButton = new Dotnetrix.CustomButton();
            this.BIMainImageList = new System.Windows.Forms.ImageList(this.components);
            this.WorkFlowViewerButton = new Dotnetrix.CustomButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DocumentacionTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DocBarFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DocumentacionMapeoButton = new Dotnetrix.CustomButton();
            this.DocCuboButton = new Dotnetrix.CustomButton();
            this.DocJobsButton = new Dotnetrix.CustomButton();
            this.DockPanel = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HerramientasFlowLayoutPanel.SuspendLayout();
            this.DocumentacionTablePanel.SuspendLayout();
            this.DocBarFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.DocumentacionTablePanel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.DockPanel, 0, 3);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 4;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1008, 680);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.37698F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.62302F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HerramientasFlowLayoutPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Herramientas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HerramientasFlowLayoutPanel
            // 
            this.HerramientasFlowLayoutPanel.Controls.Add(this.AyudaButton);
            this.HerramientasFlowLayoutPanel.Controls.Add(this.ConexionesButton);
            this.HerramientasFlowLayoutPanel.Controls.Add(this.WorkFlowViewerButton);
            this.HerramientasFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HerramientasFlowLayoutPanel.Location = new System.Drawing.Point(154, 0);
            this.HerramientasFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HerramientasFlowLayoutPanel.Name = "HerramientasFlowLayoutPanel";
            this.HerramientasFlowLayoutPanel.Size = new System.Drawing.Size(854, 40);
            this.HerramientasFlowLayoutPanel.TabIndex = 2;
            // 
            // AyudaButton
            // 
            this.AyudaButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AyudaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AyudaButton.ForeColor = System.Drawing.Color.White;
            this.AyudaButton.Location = new System.Drawing.Point(3, 3);
            this.AyudaButton.Name = "AyudaButton";
            this.AyudaButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.AyudaButton.Size = new System.Drawing.Size(91, 34);
            this.AyudaButton.TabIndex = 5;
            this.AyudaButton.Text = "? Ayuda";
            this.AyudaButton.UseVisualStyleBackColor = true;
            this.AyudaButton.Click += new System.EventHandler(this.AyudaButton_Click);
            // 
            // ConexionesButton
            // 
            this.ConexionesButton.BackColor = System.Drawing.Color.Firebrick;
            this.ConexionesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ConexionesButton.ForeColor = System.Drawing.Color.White;
            this.ConexionesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConexionesButton.ImageIndex = 3;
            this.ConexionesButton.ImageList = this.BIMainImageList;
            this.ConexionesButton.Location = new System.Drawing.Point(100, 3);
            this.ConexionesButton.Name = "ConexionesButton";
            this.ConexionesButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.ConexionesButton.Size = new System.Drawing.Size(179, 34);
            this.ConexionesButton.TabIndex = 4;
            this.ConexionesButton.Text = "Admin Conexiones";
            this.ConexionesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConexionesButton.UseVisualStyleBackColor = true;
            this.ConexionesButton.Click += new System.EventHandler(this.ConexionesButton_Click);
            // 
            // BIMainImageList
            // 
            this.BIMainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BIMainImageList.ImageStream")));
            this.BIMainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.BIMainImageList.Images.SetKeyName(0, "mapeo.png");
            this.BIMainImageList.Images.SetKeyName(1, "cubo.png");
            this.BIMainImageList.Images.SetKeyName(2, "job.png");
            this.BIMainImageList.Images.SetKeyName(3, "conn.png");
            this.BIMainImageList.Images.SetKeyName(4, "workflowinfo.png");
            // 
            // WorkFlowViewerButton
            // 
            this.WorkFlowViewerButton.BackColor = System.Drawing.Color.Firebrick;
            this.WorkFlowViewerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.WorkFlowViewerButton.ForeColor = System.Drawing.Color.White;
            this.WorkFlowViewerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkFlowViewerButton.ImageIndex = 4;
            this.WorkFlowViewerButton.ImageList = this.BIMainImageList;
            this.WorkFlowViewerButton.Location = new System.Drawing.Point(285, 3);
            this.WorkFlowViewerButton.Name = "WorkFlowViewerButton";
            this.WorkFlowViewerButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.WorkFlowViewerButton.Size = new System.Drawing.Size(152, 34);
            this.WorkFlowViewerButton.TabIndex = 6;
            this.WorkFlowViewerButton.Text = "Workflow Info";
            this.WorkFlowViewerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkFlowViewerButton.UseVisualStyleBackColor = true;
            this.WorkFlowViewerButton.Click += new System.EventHandler(this.WorkFlowViewerButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(457, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(94, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "BI-Helper";
            // 
            // DocumentacionTablePanel
            // 
            this.DocumentacionTablePanel.ColumnCount = 2;
            this.DocumentacionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5754F));
            this.DocumentacionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.42461F));
            this.DocumentacionTablePanel.Controls.Add(this.label2, 0, 0);
            this.DocumentacionTablePanel.Controls.Add(this.DocBarFlowLayoutPanel, 1, 0);
            this.DocumentacionTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentacionTablePanel.Location = new System.Drawing.Point(0, 34);
            this.DocumentacionTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DocumentacionTablePanel.Name = "DocumentacionTablePanel";
            this.DocumentacionTablePanel.RowCount = 1;
            this.DocumentacionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DocumentacionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DocumentacionTablePanel.Size = new System.Drawing.Size(1008, 40);
            this.DocumentacionTablePanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documentación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocBarFlowLayoutPanel
            // 
            this.DocBarFlowLayoutPanel.Controls.Add(this.DocumentacionMapeoButton);
            this.DocBarFlowLayoutPanel.Controls.Add(this.DocCuboButton);
            this.DocBarFlowLayoutPanel.Controls.Add(this.DocJobsButton);
            this.DocBarFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocBarFlowLayoutPanel.Location = new System.Drawing.Point(157, 0);
            this.DocBarFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DocBarFlowLayoutPanel.Name = "DocBarFlowLayoutPanel";
            this.DocBarFlowLayoutPanel.Size = new System.Drawing.Size(851, 40);
            this.DocBarFlowLayoutPanel.TabIndex = 2;
            // 
            // DocumentacionMapeoButton
            // 
            this.DocumentacionMapeoButton.BackColor = System.Drawing.Color.Firebrick;
            this.DocumentacionMapeoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DocumentacionMapeoButton.ForeColor = System.Drawing.Color.White;
            this.DocumentacionMapeoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentacionMapeoButton.ImageIndex = 0;
            this.DocumentacionMapeoButton.ImageList = this.BIMainImageList;
            this.DocumentacionMapeoButton.Location = new System.Drawing.Point(3, 3);
            this.DocumentacionMapeoButton.Name = "DocumentacionMapeoButton";
            this.DocumentacionMapeoButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.DocumentacionMapeoButton.Size = new System.Drawing.Size(135, 37);
            this.DocumentacionMapeoButton.TabIndex = 2;
            this.DocumentacionMapeoButton.Text = "Doc Mapeos";
            this.DocumentacionMapeoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DocumentacionMapeoButton.UseVisualStyleBackColor = true;
            this.DocumentacionMapeoButton.Click += new System.EventHandler(this.DocumentacionMapeoButton_Click);
            // 
            // DocCuboButton
            // 
            this.DocCuboButton.BackColor = System.Drawing.Color.Firebrick;
            this.DocCuboButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DocCuboButton.ForeColor = System.Drawing.Color.White;
            this.DocCuboButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocCuboButton.ImageIndex = 1;
            this.DocCuboButton.ImageList = this.BIMainImageList;
            this.DocCuboButton.Location = new System.Drawing.Point(144, 3);
            this.DocCuboButton.Name = "DocCuboButton";
            this.DocCuboButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.DocCuboButton.Size = new System.Drawing.Size(124, 37);
            this.DocCuboButton.TabIndex = 3;
            this.DocCuboButton.Text = "Doc Cubos";
            this.DocCuboButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DocCuboButton.UseVisualStyleBackColor = true;
            this.DocCuboButton.Click += new System.EventHandler(this.DocCuboButton_Click);
            // 
            // DocJobsButton
            // 
            this.DocJobsButton.BackColor = System.Drawing.Color.Firebrick;
            this.DocJobsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DocJobsButton.ForeColor = System.Drawing.Color.White;
            this.DocJobsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocJobsButton.ImageIndex = 2;
            this.DocJobsButton.ImageList = this.BIMainImageList;
            this.DocJobsButton.Location = new System.Drawing.Point(274, 3);
            this.DocJobsButton.Name = "DocJobsButton";
            this.DocJobsButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.DocJobsButton.Size = new System.Drawing.Size(111, 37);
            this.DocJobsButton.TabIndex = 4;
            this.DocJobsButton.Text = "Doc Jobs";
            this.DocJobsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DocJobsButton.UseVisualStyleBackColor = true;
            this.DocJobsButton.Click += new System.EventHandler(this.DocJobsButton_Click);
            // 
            // DockPanel
            // 
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.Location = new System.Drawing.Point(0, 114);
            this.DockPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(1008, 566);
            this.DockPanel.TabIndex = 3;
            // 
            // BIMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 680);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BIMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BI HELPER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BIMainForm_Load);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HerramientasFlowLayoutPanel.ResumeLayout(false);
            this.DocumentacionTablePanel.ResumeLayout(false);
            this.DocumentacionTablePanel.PerformLayout();
            this.DocBarFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel DocumentacionTablePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DockPanel;
        private Dotnetrix.CustomButton DocumentacionMapeoButton;
        private System.Windows.Forms.FlowLayoutPanel DocBarFlowLayoutPanel;
        private Dotnetrix.CustomButton DocCuboButton;
        private Dotnetrix.CustomButton DocJobsButton;
        private System.Windows.Forms.FlowLayoutPanel HerramientasFlowLayoutPanel;
        private Dotnetrix.CustomButton AyudaButton;
        private Dotnetrix.CustomButton ConexionesButton;
        private System.Windows.Forms.ImageList BIMainImageList;
        private Dotnetrix.CustomButton WorkFlowViewerButton;
    }
}