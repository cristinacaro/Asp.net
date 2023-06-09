using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Proyecto.Models
{

    public class Producto
    {
        public int id_producto { get; set; }

        public string nombre { get; set; }

        public string categoria { get; set; }

        public string subcategoria{ get; set; }

        public string descripcion{ get; set; }

        public int precio { get; set; }
        public string foto { get; set; }


    }
}