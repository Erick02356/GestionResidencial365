using CAPA_DE_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_DATOS
{
    public class CD_Usuarios : CD_CONEXION
    {
        public List<CE_Usuario> Mostrar_Usuarios()
        {
            var lista_usuarios = new List<CE_Usuario>();
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("Mostrar_Usuarios", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new CE_Usuario
                            {
                                Id_Usuario = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                                Usuario = reader["Usuario"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Id_tipo_documento = reader["Id_documento"] != DBNull.Value ? (int)reader["Id_documento"] : 0,
                                Estado = reader["Estado"] != DBNull.Value ? (bool)reader["Estado"] : false
                            };

                            lista_usuarios.Add(usuario);
                        }
                    }
                }
            }
            return lista_usuarios;
        }

        public void AgregarUsuario(string usuario, string contrasena, int id_documento)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("AgregarUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    command.Parameters.AddWithValue("@Id_documento", id_documento);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarUsuario(int id, string usuario, string contrasena, int id_documento)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("EditarUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    command.Parameters.AddWithValue("@Id_documento", id_documento);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstadoUsuario(int id, bool estado)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("CambiarEstadoUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.ExecuteNonQuery();
                }
            }
        }

        public CE_Usuario ObtenerInformacionUsuario(int id)
        {
            CE_Usuario usuario = null;
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("ObtenerInformacionUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new CE_Usuario
                            {
                                Id_Usuario = (int)reader["Id"],
                                Usuario = reader["Usuario"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Id_tipo_documento = (int)reader["Id_documento"],
                                Estado = (bool)reader["Estado"]
                            };
                        }
                    }
                }
            }
            return usuario;
        }

        public List<CE_Usuario> BuscarUsuarioPorNombre(string nombre)
        {
            var lista_usuarios = new List<CE_Usuario>();
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("BuscarUsuarioPorNombre", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new CE_Usuario
                            {
                                Id_Usuario = (int)reader["Id"],
                                Usuario = reader["Usuario"].ToString(),
                                Estado = (bool)reader["Estado"],
                                Id_tipo_documento = (int)reader["Id_documento"]
                            };

                            lista_usuarios.Add(usuario);
                        }
                    }
                }
            }
            return lista_usuarios;
        }

        public void CambiarContrasena(int id, string nuevaContrasena)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (var command = new SqlCommand("CambiarContrasena", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasena);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}