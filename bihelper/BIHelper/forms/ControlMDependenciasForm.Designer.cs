namespace BIHelper.forms
{
    partial class ControlMDependenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMDependenciasForm));
            this.jobsTreeView = new System.Windows.Forms.TreeView();
            this.IconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ExplorarArchivoXmlButton = new Dotnetrix.CustomButton();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobDefinitionDataGridView = new System.Windows.Forms.DataGridView();
            this.EliminarColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentarButton = new Dotnetrix.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.jobDefinitionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsTreeView
            // 
            this.jobsTreeView.CheckBoxes = true;
            this.jobsTreeView.ImageIndex = 0;
            this.jobsTreeView.ImageList = this.IconsImageList;
            this.jobsTreeView.Location = new System.Drawing.Point(12, 81);
            this.jobsTreeView.Name = "jobsTreeView";
            this.jobsTreeView.SelectedImageIndex = 0;
            this.jobsTreeView.Size = new System.Drawing.Size(511, 475);
            this.jobsTreeView.TabIndex = 0;
            this.jobsTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.jobsTreeView_AfterCheck);
            // 
            // IconsImageList
            // 
            this.IconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsImageList.ImageStream")));
            this.IconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsImageList.Images.SetKeyName(0, "rootdesktop.jpg");
            this.IconsImageList.Images.SetKeyName(1, "appnode.jpg");
            this.IconsImageList.Images.SetKeyName(2, "groupnode.jpg");
            this.IconsImageList.Images.SetKeyName(3, "jobnode.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione los jobs para los que desea obtener las dependencias:";
            // 
            // ExplorarArchivoXmlButton
            // 
            this.ExplorarArchivoXmlButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExplorarArchivoXmlButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExplorarArchivoXmlButton.ForeColor = System.Drawing.Color.White;
            this.ExplorarArchivoXmlButton.Location = new System.Drawing.Point(906, 12);
            this.ExplorarArchivoXmlButton.Name = "ExplorarArchivoXmlButton";
            this.ExplorarArchivoXmlButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.ExplorarArchivoXmlButton.Size = new System.Drawing.Size(56, 27);
            this.ExplorarArchivoXmlButton.TabIndex = 4;
            this.ExplorarArchivoXmlButton.Text = "...";
            this.ExplorarArchivoXmlButton.UseVisualStyleBackColor = true;
            this.ExplorarArchivoXmlButton.Click += new System.EventHandler(this.ExplorarArchivoXmlButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(370, 12);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(530, 27);
            this.FileNameTextBox.TabIndex = 2;
            this.FileNameTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el archivo *.xml exportado de Control M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jobs seleccionados:";
            // 
            // jobDefinitionDataGridView
            // 
            this.jobDefinitionDataGridView.AllowUserToAddRows = false;
            this.jobDefinitionDataGridView.AllowUserToDeleteRows = false;
            this.jobDefinitionDataGridView.AutoGenerateColumns = false;
            this.jobDefinitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jobDefinitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDefinitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.jobDefinitionDataGridView.DataSource = this.jobDefinitionBindingSource;
            this.jobDefinitionDataGridView.Location = new System.Drawing.Point(539, 143);
            this.jobDefinitionDataGridView.Name = "jobDefinitionDataGridView";
            this.jobDefinitionDataGridView.ReadOnly = true;
            this.jobDefinitionDataGridView.RowHeadersVisible = false;
            this.jobDefinitionDataGridView.Size = new System.Drawing.Size(469, 413);
            this.jobDefinitionDataGridView.TabIndex = 7;
            this.jobDefinitionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDefinitionDataGridView_CellClick);
            // 
            // EliminarColumn
            // 
            this.EliminarColumn.HeaderText = "";
            this.EliminarColumn.Name = "EliminarColumn";
            this.EliminarColumn.ReadOnly = true;
            this.EliminarColumn.Text = "Eliminar";
            this.EliminarColumn.UseColumnTextForLinkValue = true;
            this.EliminarColumn.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "MemName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 108;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JobName";
            this.dataGridViewTextBoxColumn4.HeaderText = "JobName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Group";
            this.dataGridViewTextBoxColumn2.HeaderText = "Group";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Application";
            this.dataGridViewTextBoxColumn1.HeaderText = "Application";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 111;
            // 
            // jobDefinitionBindingSource
            // 
            this.jobDefinitionBindingSource.DataSource = typeof(BIHelper.lib.controlm.JobDefinition);
            // 
            // DocumentarButton
            // 
            this.DocumentarButton.BackColor = System.Drawing.Color.Firebrick;
            this.DocumentarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DocumentarButton.ForeColor = System.Drawing.Color.White;
            this.DocumentarButton.Location = new System.Drawing.Point(779, 58);
            this.DocumentarButton.Name = "DocumentarButton";
            this.DocumentarButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.DocumentarButton.Size = new System.Drawing.Size(183, 33);
            this.DocumentarButton.TabIndex = 8;
            this.DocumentarButton.Text = "Obtener documentos";
            this.DocumentarButton.UseVisualStyleBackColor = true;
            this.DocumentarButton.Click += new System.EventHandler(this.DocumentarButton_Click);
            // 
            // ControlMDependenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.DocumentarButton);
            this.Controls.Add(this.jobDefinitionDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExplorarArchivoXmlButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobsTreeView);
            this.Name = "ControlMDependenciasForm";
            this.Text = "ControlMDependenciasForm";
            ((System.ComponentModel.ISupportInitialize)(this.jobDefinitionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDefinitionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView jobsTreeView;
        private System.Windows.Forms.Label label1;
        private Dotnetrix.CustomButton ExplorarArchivoXmlButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList IconsImageList;
        private System.Windows.Forms.BindingSource jobDefinitionBindingSource;
        private System.Windows.Forms.DataGridView jobDefinitionDataGridView;
        private System.Windows.Forms.DataGridViewLinkColumn EliminarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Dotnetrix.CustomButton DocumentarButton;
    }
}