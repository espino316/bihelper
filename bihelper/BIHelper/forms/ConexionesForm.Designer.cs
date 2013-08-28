namespace BIHelper.forms
{
    partial class ConexionesForm
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
            this.ConexionesTabControl = new System.Windows.Forms.TabControl();
            this.ArtusTabPage = new System.Windows.Forms.TabPage();
            this.conexionArtusDataGridView = new System.Windows.Forms.DataGridView();
            this.EliminarConexion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EditConexion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conexionArtusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NuevaConexionArtusLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ConexionesTabControl.SuspendLayout();
            this.ArtusTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConexionesTabControl
            // 
            this.ConexionesTabControl.Controls.Add(this.ArtusTabPage);
            this.ConexionesTabControl.Location = new System.Drawing.Point(12, 12);
            this.ConexionesTabControl.Name = "ConexionesTabControl";
            this.ConexionesTabControl.SelectedIndex = 0;
            this.ConexionesTabControl.Size = new System.Drawing.Size(996, 544);
            this.ConexionesTabControl.TabIndex = 0;
            // 
            // ArtusTabPage
            // 
            this.ArtusTabPage.Controls.Add(this.conexionArtusDataGridView);
            this.ArtusTabPage.Controls.Add(this.NuevaConexionArtusLinkLabel);
            this.ArtusTabPage.Controls.Add(this.label1);
            this.ArtusTabPage.Location = new System.Drawing.Point(4, 29);
            this.ArtusTabPage.Name = "ArtusTabPage";
            this.ArtusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ArtusTabPage.Size = new System.Drawing.Size(988, 511);
            this.ArtusTabPage.TabIndex = 0;
            this.ArtusTabPage.Text = "Artus";
            this.ArtusTabPage.UseVisualStyleBackColor = true;
            // 
            // conexionArtusDataGridView
            // 
            this.conexionArtusDataGridView.AllowUserToAddRows = false;
            this.conexionArtusDataGridView.AllowUserToDeleteRows = false;
            this.conexionArtusDataGridView.AutoGenerateColumns = false;
            this.conexionArtusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conexionArtusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarConexion,
            this.EditConexion,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.conexionArtusDataGridView.DataSource = this.conexionArtusBindingSource;
            this.conexionArtusDataGridView.Location = new System.Drawing.Point(3, 77);
            this.conexionArtusDataGridView.Name = "conexionArtusDataGridView";
            this.conexionArtusDataGridView.ReadOnly = true;
            this.conexionArtusDataGridView.Size = new System.Drawing.Size(982, 453);
            this.conexionArtusDataGridView.TabIndex = 2;
            this.conexionArtusDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conexionArtusDataGridView_CellClick);
            // 
            // EliminarConexion
            // 
            this.EliminarConexion.HeaderText = "";
            this.EliminarConexion.Name = "EliminarConexion";
            this.EliminarConexion.ReadOnly = true;
            this.EliminarConexion.Text = "Eliminar";
            this.EliminarConexion.UseColumnTextForLinkValue = true;
            // 
            // EditConexion
            // 
            this.EditConexion.HeaderText = "";
            this.EditConexion.Name = "EditConexion";
            this.EditConexion.ReadOnly = true;
            this.EditConexion.Text = "Actualizar";
            this.EditConexion.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Servidor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Servidor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BaseDatos";
            this.dataGridViewTextBoxColumn3.HeaderText = "BaseDatos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // conexionArtusBindingSource
            // 
            this.conexionArtusBindingSource.DataSource = typeof(BIHelper.lib.ConexionMetaDataArtus);
            // 
            // NuevaConexionArtusLinkLabel
            // 
            this.NuevaConexionArtusLinkLabel.AutoSize = true;
            this.NuevaConexionArtusLinkLabel.Location = new System.Drawing.Point(17, 12);
            this.NuevaConexionArtusLinkLabel.Name = "NuevaConexionArtusLinkLabel";
            this.NuevaConexionArtusLinkLabel.Size = new System.Drawing.Size(201, 20);
            this.NuevaConexionArtusLinkLabel.TabIndex = 1;
            this.NuevaConexionArtusLinkLabel.TabStop = true;
            this.NuevaConexionArtusLinkLabel.Text = "Capturar una nueva conexión";
            this.NuevaConexionArtusLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NuevaConexionArtusLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexiones disponibles:";
            // 
            // ConexionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 560);
            this.Controls.Add(this.ConexionesTabControl);
            this.Name = "ConexionesForm";
            this.Text = "ConexionesForm";
            this.Load += new System.EventHandler(this.ConexionesForm_Load);
            this.ConexionesTabControl.ResumeLayout(false);
            this.ArtusTabPage.ResumeLayout(false);
            this.ArtusTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ConexionesTabControl;
        private System.Windows.Forms.TabPage ArtusTabPage;
        private System.Windows.Forms.LinkLabel NuevaConexionArtusLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView conexionArtusDataGridView;
        private System.Windows.Forms.BindingSource conexionArtusBindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn EliminarConexion;
        private System.Windows.Forms.DataGridViewLinkColumn EditConexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}