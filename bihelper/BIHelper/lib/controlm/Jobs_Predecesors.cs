using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIHelper.lib.controlm
{
    /// <summary>
    /// Estructura que representa la relación entre un Job y su Job Predecesor
    /// </summary>
    public class Jobs_Predecesors
    {
        public override string ToString()
        {
            return Job + " | " + Predecesor;
        }

        /// <summary>
        /// El Job
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// El predecesor del job
        /// </summary>
        public string Predecesor { get; set; }

    } // end Jobs_Predecesors
}
