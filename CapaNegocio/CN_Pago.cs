using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Pagos
    {
        private CD_Pagos objCD_Pagos = new CD_Pagos();

        // Método para listar pagos
        public List<Pagos> Listar()
        {
            return objCD_Pagos.Listar();
        }

        // Método para registrar un pago
        public bool Registrar(Pagos pago, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio
            if (pago.oEstudiante.CodigoAlumno <= 0)
            {
                mensaje = "El código del alumno debe ser mayor a 0.\n";
            }

            if (pago.CuotasPagadas < 0)
            {
                mensaje += "La cantidad de cuotas pagadas no puede ser negativa.\n";
            }

            if (pago.TalleresInscritos < 0)
            {
                mensaje += "La cantidad de talleres inscritos no puede ser negativa.\n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return false; // No se procede si hay errores
            }

            // Llamar a la capa de datos
            return objCD_Pagos.Insertar(pago, out mensaje);
        }
    }
}
