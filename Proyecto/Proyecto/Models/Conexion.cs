using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


namespace Proyecto.Models
{
    public class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["ProyectoContext"].ToString();

    }
}