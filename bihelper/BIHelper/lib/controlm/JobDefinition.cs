using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib.controlm
{
    /// <summary>
    /// Clase que representa una definición de Job
    /// </summary>
    public class JobDefinition
    {
        /// <summary>
        /// La aplicación a la que pertenece el Job
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// El grupo al que pertenece el Job
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// El nombre descripción del Job
        /// </summary>
        public string MemName { get; set; }

        /// <summary>
        /// El nombre del Job
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// Regresa una cadena representando el objeeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return 
                string.Concat(
                    MemName,
                    ",",
                    Group,
                    ",",
                    Application
                );

        } // end ToString

        /// <summary>
        /// Compara un objeto con la instancia actual de <see cref="JobDefinition"/>
        /// </summary>
        /// <param name="obj">El objeto a comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj != null && obj != Convert.DBNull)
            {
                JobDefinition instance = (JobDefinition)obj;

                return (
                    this.Application == instance.Application
                    && this.Group == instance.Group
                    && this.JobName == instance.JobName
                    && this.MemName == instance.MemName
                );
            }
            else
            {
                return base.Equals(obj);
            }
        } // end Equals

        /// <summary>
        /// Devuelve un hash de la instancia actual
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    } // JobDefinition
}
