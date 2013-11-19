namespace BIHelper.forms
{
    partial class WorkFlowViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFlowViewerForm));
            this.ExplorarArchivoXmlIPCButton = new Dotnetrix.CustomButton();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkflowsTreeView = new System.Windows.Forms.TreeView();
            this.IconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ExplorarArchivoXmlIPCButton
            // 
            this.ExplorarArchivoXmlIPCButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExplorarArchivoXmlIPCButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExplorarArchivoXmlIPCButton.ForeColor = System.Drawing.Color.White;
            this.ExplorarArchivoXmlIPCButton.Location = new System.Drawing.Point(901, 3);
            this.ExplorarArchivoXmlIPCButton.Name = "ExplorarArchivoXmlIPCButton";
            this.ExplorarArchivoXmlIPCButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.ExplorarArchivoXmlIPCButton.Size = new System.Drawing.Size(107, 27);
            this.ExplorarArchivoXmlIPCButton.TabIndex = 4;
            this.ExplorarArchivoXmlIPCButton.Text = "...";
            this.ExplorarArchivoXmlIPCButton.UseVisualStyleBackColor = true;
            this.ExplorarArchivoXmlIPCButton.Click += new System.EventHandler(this.ExplorarArchivoXmlIPCButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(396, 3);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(499, 27);
            this.FileNameTextBox.TabIndex = 2;
            this.FileNameTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el archivo *.xml exportado de Informatica PC:";
            // 
            // WorkflowsTreeView
            // 
            this.WorkflowsTreeView.ImageIndex = 0;
            this.WorkflowsTreeView.ImageList = this.IconsImageList;
            this.WorkflowsTreeView.Location = new System.Drawing.Point(12, 38);
            this.WorkflowsTreeView.Name = "WorkflowsTreeView";
            this.WorkflowsTreeView.SelectedImageIndex = 0;
            this.WorkflowsTreeView.Size = new System.Drawing.Size(996, 510);
            this.WorkflowsTreeView.TabIndex = 5;
            // 
            // IconsImageList
            // 
            this.IconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsImageList.ImageStream")));
            this.IconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsImageList.Images.SetKeyName(0, "workflow.png");
            this.IconsImageList.Images.SetKeyName(1, "session.png");
            this.IconsImageList.Images.SetKeyName(2, "mapping.png");
            this.IconsImageList.Images.SetKeyName(3, "folder.png");
            this.IconsImageList.Images.SetKeyName(4, "source.png");
            this.IconsImageList.Images.SetKeyName(5, "target.png");
            this.IconsImageList.Images.SetKeyName(6, "jobnode.jpg");
            this.IconsImageList.Images.SetKeyName(7, "transformation.png");
            // 
            // WorkFlowViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.WorkflowsTreeView);
            this.Controls.Add(this.ExplorarArchivoXmlIPCButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "WorkFlowViewerForm";
            this.Text = "WorkFlowViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dotnetrix.CustomButton ExplorarArchivoXmlIPCButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView WorkflowsTreeView;
        private System.Windows.Forms.ImageList IconsImageList;
    }
}