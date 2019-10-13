using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public ICollection<Venta>  Ventas { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
