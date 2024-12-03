using CapaDatos.Properties;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Estudiante
    {
        public List<Estudiante> Listar()
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT CodigoAlumno, Nivel FROM Estudiante";
                    SqlCommand cmd = new SqlCommand(query, conexion)
                    {
                        CommandType = CommandType.Text
                    };

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Estudiante
                            {
                                CodigoAlumno = Convert.ToInt32(dr["CodigoAlumno"]),
                                Nivel = Convert.ToInt32(dr["Nivel"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Estudiante>();
                }
            }

            return lista;
        }

        public bool Insertar(Estudiante estudiante, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO Estudiante (CodigoAlumno, Nivel) VALUES (@CodigoAlumno, @Nivel)";
                    SqlCommand cmd = new SqlCommand(query, conexion)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@CodigoAlumno", estudiante.CodigoAlumno);
                    cmd.Parameters.AddWithValue("@Nivel", estudiante.Nivel);

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
