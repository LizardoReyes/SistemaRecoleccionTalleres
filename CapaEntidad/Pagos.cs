using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public Estudiante oEstudiante { get; set; }
        public int CuotasPagadas { get; set; }
        public int TalleresInscritos { get; set; }
    }

}
