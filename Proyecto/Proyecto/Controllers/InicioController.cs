using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;
using System.Data.SqlClient;


namespace Proyecto.Controllers
{
    public class InicioController : Controller
    {

        // Cadena de conexion a la bd
        static string cadena = "server=DESKTOP-O59N4G8\\SQLEXPRESS ; database=Prueba ; integrated security = true";

        // GET: Inicio
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            

           using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                string sqlQuery = "SELECT COUNT(*) FROM usuario WHERE email= '@email' AND password = '@password'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@email", usuario.email);
                    command.Parameters.AddWithValue("@password",usuario.password);

                    usuario.idUsuario = (int)command.ExecuteScalar();

                  
                }

                connection.Close();
            }

            if (usuario.idUsuario !=0)
            {
                Session["usuario"] = usuario;
                return RedirectToAction("Index", "Home");

                Console.WriteLine("Login successful");
            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
              
            }

         
        }


     
    
      
    }
    }