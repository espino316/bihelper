namespace BIHelper.forms
{
    partial class blankForm
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
            this.InicioWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // InicioWebBrowser
            // 
            this.InicioWebBrowser.Location = new System.Drawing.Point(40, 35);
            this.InicioWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.InicioWebBrowser.Name = "InicioWebBrowser";
            this.InicioWebBrowser.Size = new System.Drawing.Size(938, 512);
            this.InicioWebBrowser.TabIndex = 0;
            // 
            // blankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 590);
            this.Controls.Add(this.InicioWebBrowser);
            this.Name = "blankForm";
            this.Text = "blankForm";
            this.Load += new System.EventHandler(this.blankForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser InicioWebBrowser;
    }
}