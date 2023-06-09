using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Proyecto.Models
{
    
    public class DetallePedido
    {
        public int  id_detalle_pedido { get; set; }
      
        public int  precio_unitario { get; set; }
        
        public int cantidad { get; set; }
       
        public Pedido id_pedido{ get; set; }
    
       


    }
}