using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Proyecto.Models
{

    public class Pedido
    {
        public int id_pedido { get; set; }

        public string fecha { get; set; }

        public string estado { get; set; }

        public int precio { get; set; }

        public Producto id_producto { get; set; }

        public Usuario id_usuario { get; set; }
      


    }
}