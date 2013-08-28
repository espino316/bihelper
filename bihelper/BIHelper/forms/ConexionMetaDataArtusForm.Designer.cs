namespace BIHelper.forms
{
    partial class ConexionMetadataArtusForm
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
            System.Windows.Forms.Label baseDatosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label servidorLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.baseDatosTextBox = new System.Windows.Forms.TextBox();
            this.conexionArtusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.servidorTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarButton = new Dotnetrix.CustomButton();
            this.CancelarButton = new Dotnetrix.CustomButton();
            this.ProbarConexionButton = new Dotnetrix.CustomButton();
            this.AyudaButton = new Dotnetrix.CustomButton();
            baseDatosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            servidorLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDatosLabel
            // 
            baseDatosLabel.AutoSize = true;
            baseDatosLabel.Location = new System.Drawing.Point(25, 137);
            baseDatosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            baseDatosLabel.Name = "baseDatosLabel";
            baseDatosLabel.Size = new System.Drawing.Size(86, 20);
            baseDatosLabel.TabIndex = 1;
            baseDatosLabel.Text = "Base Datos:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 63);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(25, 211);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(74, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // servidorLabel
            // 
            servidorLabel.AutoSize = true;
            servidorLabel.Location = new System.Drawing.Point(25, 100);
            servidorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            servidorLabel.Name = "servidorLabel";
            servidorLabel.Size = new System.Drawing.Size(67, 20);
            servidorLabel.TabIndex = 7;
            servidorLabel.Text = "Servidor:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(25, 174);
            usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(62, 20);
            usuarioLabel.TabIndex = 9;
            usuarioLabel.Text = "Usuario:";
            // 
            // baseDatosTextBox
            // 
            this.baseDatosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conexionArtusBindingSource, "BaseDatos", true));
            this.baseDatosTextBox.Location = new System.Drawing.Point(120, 132);
            this.baseDatosTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baseDatosTextBox.Name = "baseDatosTextBox";
            this.baseDatosTextBox.Size = new System.Drawing.Size(153, 27);
            this.baseDatosTextBox.TabIndex = 3;
            // 
            // conexionArtusBindingSource
            // 
            this.conexionArtusBindingSource.DataSource = typeof(BIHelper.lib.ConexionMetaDataArtus);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conexionArtusBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(120, 58);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(153, 27);
            this.nombreTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conexionArtusBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(120, 206);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '?';
            this.passwordTextBox.Size = new System.Drawing.Size(153, 27);
            this.passwordTextBox.TabIndex = 5;
            // 
            // servidorTextBox
            // 
            this.servidorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conexionArtusBindingSource, "Servidor", true));
            this.servidorTextBox.Location = new System.Drawing.Point(120, 95);
            this.servidorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.servidorTextBox.Name = "servidorTextBox";
            this.servidorTextBox.Size = new System.Drawing.Size(217, 27);
            this.servidorTextBox.TabIndex = 2;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conexionArtusBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(120, 169);
            this.usuarioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(217, 27);
            this.usuarioTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datos de Conexión";
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.Firebrick;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GuardarButton.ForeColor = System.Drawing.Color.White;
            this.GuardarButton.Location = new System.Drawing.Point(234, 303);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.GuardarButton.Size = new System.Drawing.Size(103, 40);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.Firebrick;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CancelarButton.ForeColor = System.Drawing.Color.White;
            this.CancelarButton.Location = new System.Drawing.Point(120, 303);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.CancelarButton.Size = new System.Drawing.Size(103, 40);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ProbarConexionButton
            // 
            this.ProbarConexionButton.BackColor = System.Drawing.Color.Firebrick;
            this.ProbarConexionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ProbarConexionButton.ForeColor = System.Drawing.Color.White;
            this.ProbarConexionButton.Location = new System.Drawing.Point(120, 257);
            this.ProbarConexionButton.Name = "ProbarConexionButton";
            this.ProbarConexionButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.ProbarConexionButton.Size = new System.Drawing.Size(217, 40);
            this.ProbarConexionButton.TabIndex = 6;
            this.ProbarConexionButton.Text = "Probar Conexion";
            this.ProbarConexionButton.UseVisualStyleBackColor = true;
            this.ProbarConexionButton.Click += new System.EventHandler(this.ProbarConexionButton_Click);
            // 
            // AyudaButton
            // 
            this.AyudaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AyudaButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AyudaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyudaButton.ForeColor = System.Drawing.Color.White;
            this.AyudaButton.Location = new System.Drawing.Point(306, 1);
            this.AyudaButton.Name = "AyudaButton";
            this.AyudaButton.RoundCorners = ((Dotnetrix.Corners)((((Dotnetrix.Corners.TopLeft | Dotnetrix.Corners.TopRight) 
            | Dotnetrix.Corners.BottomLeft) 
            | Dotnetrix.Corners.BottomRight)));
            this.AyudaButton.Size = new System.Drawing.Size(61, 23);
            this.AyudaButton.TabIndex = 12;
            this.AyudaButton.Text = "? Ayuda";
            this.AyudaButton.UseVisualStyleBackColor = true;
            this.AyudaButton.Click += new System.EventHandler(this.AyudaButton_Click);
            // 
            // ConexionMetadataArtusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 368);
            this.Controls.Add(this.AyudaButton);
            this.Controls.Add(this.ProbarConexionButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(baseDatosLabel);
            this.Controls.Add(this.baseDatosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(servidorLabel);
            this.Controls.Add(this.servidorTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConexionMetadataArtusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión a Metadata de Artus";
            ((System.ComponentModel.ISupportInitialize)(this.conexionArtusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource conexionArtusBindingSource;
        private System.Windows.Forms.TextBox baseDatosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox servidorTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label1;
        private Dotnetrix.CustomButton GuardarButton;
        private Dotnetrix.CustomButton CancelarButton;
        private Dotnetrix.CustomButton ProbarConexionButton;
        private Dotnetrix.CustomButton AyudaButton;
    }
}