using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Estudiante
    {
        private CD_Estudiante objCD_Estudiante = new CD_Estudiante();

        // Método para listar estudiantes
        public List<Estudiante> Listar()
        {
            return objCD_Estudiante.Listar();
        }

        // Método para registrar un estudiante
        public bool Registrar(Estudiante estudiante, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (estudiante.CodigoAlumno <= 0)
            {
                mensaje = "El código del alumno debe ser mayor a 0.\n";
            }

            if (estudiante.Nivel < 1 || estudiante.Nivel > 3)
            {
                mensaje += "El nivel educativo debe ser 1 (Inicial), 2 (Primaria) o 3 (Secundaria).\n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return false; // No se procede si hay errores
            }

            // Llamar a la capa de datos
            return objCD_Estudiante.Insertar(estudiante, out mensaje);
        }
    }
}
