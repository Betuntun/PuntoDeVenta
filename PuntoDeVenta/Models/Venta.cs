using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class Venta
    {

        public int Id { get; set; }
       
        public DateTime FechaDeVenta { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Descuento { get; set; }
        public int? ClienteId { get; set; }
        public ICollection<ProductoVenta>  ProductosVentas { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}
