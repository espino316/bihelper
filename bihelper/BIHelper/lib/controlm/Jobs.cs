using System.Collections.Generic;

namespace BIHelper.lib.controlm
{
    /// <summary>
    /// Clase que representa un job
    /// </summary>
    public class Jobs
    {
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// El nivel en el que se encuentra el job
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// El nombre del job
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// El listado de sus predecesores
        /// </summary>
        public List<Jobs> Predecesors { get; set; }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="Jobs"/>
        /// </summary>
        public Jobs()
        {
            Level = 0;
            Name = "";
            Predecesors = new List<Jobs>();

        } // end Jobs

    } // end class Jobs
}
