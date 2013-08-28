using System;
using System.IO;
using System.Windows.Forms;

namespace BIHelper.forms
{
    /// <summary>
    /// Formulario en blanco, se presenta al inicio del sistema
    /// </summary>
    public partial class blankForm : GradientForms.BaseInnerFormGradient
    {
        #region Constructors

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="blankForm"/>
        /// </summary>
        public blankForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maneja el evento "Load" del formulario "blankForm"
        /// </summary>
        /// <param name="sender">El formulario "blankForm"</param>
        /// <param name="e">Los argumentos del evento</param>
        private void blankForm_Load(object sender, EventArgs e)
        {
            try
            {
                string curDir = Directory.GetCurrentDirectory();
                this.InicioWebBrowser.Url = new Uri(String.Format("file:///{0}/help/Inicio.htm", curDir));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

            } // end catch

        } // end void blankForm_Load

        #endregion

    } // end class blankForm

} // end namespace BIHelper.forms