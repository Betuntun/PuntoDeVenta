using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public virtual ICollection<Producto> Productos { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
