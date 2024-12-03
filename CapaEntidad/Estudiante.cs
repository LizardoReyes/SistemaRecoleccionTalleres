using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Estudiante
    {
        public int CodigoAlumno { get; set; }

        public string Nombre { get; set; }

        // Nivel educativo (1: Inicial, 2: Primaria, 3: Secundaria)
        public int Nivel { get; set; }
    }

}
