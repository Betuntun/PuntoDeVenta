using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Venta> Ventas{ get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
