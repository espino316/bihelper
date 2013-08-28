using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BIHelper
{
    /// <summary>
    /// Clase inicial de la aplicación
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada de la aplicación
        /// </summary>
        [STAThread]
        static void Main()
        {
            //  Establecemos estilos visuales, es una aplicación WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  Corremos el formulario principal
            Application.Run(new forms.BIMainForm());

        } // end Main

    } // end clas Program

} // end namespace BIHelper