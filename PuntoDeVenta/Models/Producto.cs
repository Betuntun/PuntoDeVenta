using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public string Ingredientes { get; set; }
        public string rutaImagen { get; set; }
        public  int CategoriaId { get; set; }
        public ICollection<ProductoVenta> ProductosVentas { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string ApplicationUserID { get; set; }

       
        public virtual ApplicationUser ApplicationUser { get; set; }



    }
}
