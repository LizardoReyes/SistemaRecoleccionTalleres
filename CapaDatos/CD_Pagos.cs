using CapaDatos.Properties;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pagos
    {
        public List<Pagos> Listar()
        {
            List<Pagos> lista = new List<Pagos>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdPago, CodigoAlumno, CuotasPagadas, TalleresInscritos FROM Pagos";
                    SqlCommand cmd = new SqlCommand(query, conexion)
                    {
                        CommandType = CommandType.Text
                    };

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pagos
                            {
                                IdPago = Convert.ToInt32(dr["IdPago"]),
                                oEstudiante = new Estudiante
                                {
                                    CodigoAlumno = Convert.ToInt32(dr["CodigoAlumno"])
                                },
                                CuotasPagadas = Convert.ToInt32(dr["CuotasPagadas"]),
                                TalleresInscritos = Convert.ToInt32(dr["TalleresInscritos"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Pagos>();
                }
            }

            return lista;
        }

        public bool Insertar(Pagos pago, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO Pagos (CodigoAlumno, CuotasPagadas, TalleresInscritos) VALUES (@CodigoAlumno, @CuotasPagadas, @TalleresInscritos)";
                    SqlCommand cmd = new SqlCommand(query, conexion)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@CodigoAlumno", pago.oEstudiante.CodigoAlumno);
                    cmd.Parameters.AddWithValue("@CuotasPagadas", pago.CuotasPagadas);
                    cmd.Parameters.AddWithValue("@TalleresInscritos", pago.TalleresInscritos);

                    conexion.Open();
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }

            return resultado;
        }
    }
}
