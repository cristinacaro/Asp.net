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

        


     
    
      
    }
    }