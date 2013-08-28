using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIHelper.lib
{
    /// <summary>
    /// Esta clase contiene los formularios a utilizar en la aplicación
    /// </summary>
    class MyForms
    {
        /// <summary>
        /// La ruta al archivo del ícono
        /// </summary>
        private static string fileICO = Environment.CurrentDirectory + "//bihelper.ico";

        /// <summary>
        /// Configura el ícono en una forma
        /// </summary>
        /// <param name="form"></param>
        public static void SetICON(Form form)
        {
            form.Icon = new System.Drawing.Icon(fileICO);
        }

        private static forms.DocMapeoForm _DocMapeo;

        /// <summary>
        /// Formulario para documentar un mapeo
        /// </summary>
        public static forms.DocMapeoForm DocMapeo
        {
            get
            {
                if (_DocMapeo == null)
                    _DocMapeo = new forms.DocMapeoForm();

                if (_DocMapeo.IsDisposed)
                    _DocMapeo = new forms.DocMapeoForm();

                SetICON(_DocMapeo);

                return _DocMapeo;
            }
            set { _DocMapeo = value; }
        }

        private static forms.ConexionesForm _Conexiones;

        /// <summary>
        /// Formulario para manejar las conexiones
        /// </summary>
        public static forms.ConexionesForm Conexiones
        {
            get
            {
                if (_Conexiones == null)
                    _Conexiones = new forms.ConexionesForm();

                if (_Conexiones.IsDisposed)
                    _Conexiones = new forms.ConexionesForm();

                SetICON(_Conexiones);

                return _Conexiones;
            }
            set
            {
                _Conexiones = value;
            }
        }

        private static forms.ConexionMetadataArtusForm _ConexionMetadataArtus;

        /// <summary>
        /// Formulario para dar actualizar / dar de alta una conexion a metadata de artus
        /// </summary>
        public static forms.ConexionMetadataArtusForm ConexionMetadataArtus
        {
            get
            {
                if (_ConexionMetadataArtus == null)
                    _ConexionMetadataArtus = new forms.ConexionMetadataArtusForm();

                if (_ConexionMetadataArtus.IsDisposed)
                    _ConexionMetadataArtus = new forms.ConexionMetadataArtusForm();

                SetICON(_ConexionMetadataArtus);

                return _ConexionMetadataArtus;
            }
            set
            {
                _ConexionMetadataArtus = value;
            }
        }

        private static forms.AnalisisCuboForm _AnalisisCubo;

        /// <summary>
        /// Formulario para dar actualizar / dar de alta una conexion a metadata de artus
        /// </summary>
        public static forms.AnalisisCuboForm AnalisisCubo
        {
            get
            {
                if (_AnalisisCubo == null)
                    _AnalisisCubo = new forms.AnalisisCuboForm();

                if (_AnalisisCubo.IsDisposed)
                    _AnalisisCubo = new forms.AnalisisCuboForm();

                SetICON(_AnalisisCubo);

                return _AnalisisCubo;
            }
            set
            {
                _AnalisisCubo = value;
            }
        }

        private static forms.ControlMDependenciasForm _ControlMDependencias;


        /// <summary>
        /// Formulario para dar actualizar / dar de alta una conexion a metadata de artus
        /// </summary>
        public static forms.ControlMDependenciasForm ControlMDependencias
        {
            get
            {
                if (_ControlMDependencias == null)
                    _ControlMDependencias = new forms.ControlMDependenciasForm();

                if (_ControlMDependencias.IsDisposed)
                    _ControlMDependencias = new forms.ControlMDependenciasForm();

                SetICON(_ControlMDependencias);

                return _ControlMDependencias;
            }
            set
            {
                _ControlMDependencias = value;
            }
        }

        private static forms.blankForm _blank;

        /// <summary>
        /// Formulario en blanco
        /// </summary>
        public static forms.blankForm blank
        {
            get
            {
                if (_blank == null)
                    _blank = new forms.blankForm();

                if (_blank.IsDisposed)
                    _blank = new forms.blankForm();

                SetICON(_blank);

                return _blank;
            }
            set
            {
                _blank = value;
            }
        }

    } // end class MyForms

} // end namespace BIHelper.lib
