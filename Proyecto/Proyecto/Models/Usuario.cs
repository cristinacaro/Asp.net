using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Proyecto.Models
{
    
    public class Usuario
    {
        public int  idUsuario { get; set; }
      
        public string  Nombre { get; set; }
        
        public int telefono { get; set; }
       
        public string direccion { get; set; }
    
        public string email { get; set; }
        
        public string password { get; set; }


    }
}