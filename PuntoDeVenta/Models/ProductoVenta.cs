using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class ProductoVenta
    {
        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public  Producto Producto { get; set; }
        public Venta Venta { get; set; }
    }
}
