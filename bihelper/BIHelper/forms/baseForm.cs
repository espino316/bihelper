using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIHelper.forms
{
    /// <summary>
    /// Formulario en el que basamos los demás. Contiene las propiedades comúnes
    /// </summary>
    public partial class baseForm : GradientForms.BaseInnerFormGradient
    {
        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="baseForm"/>
        /// </summary>
        public baseForm()
        {
            InitializeComponent();

        } // end baseForm

    } // end class baseForm

} // end namespace BIHelper.forms
