using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Models
{

    public class Usuario
    {
        public int id_usuario { get; set; }

        public string nombre { get; set; }

        public int telefono { get; set; }

        public string direcion { get; set; }

        public string email { get; set; }

        public string password { get; set; }

 

        public List<Usuario> Listar()
        {


            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlConnection oconection = new SqlConnection(Conexion.cn))
                {
                    string query = "select * from dbo.usuario";
                    SqlCommand cd = new SqlCommand(query, oconection);
                    cd.Connection.Open();
                 //var resultado =   cd.ExecuteNonQuery();


                    using (SqlDataReader dr = cd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                telefono = Convert.ToInt32(dr["telefono"]),
                                direcion = dr["direccion"].ToString(),
                                email = dr["email"].ToString(),
                                password = dr["pasword"].ToString()

                            }
                                );
                        }

                    }
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                lista = new List<Usuario>();
            }
            return lista;
        }



    }
}