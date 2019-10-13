using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public IGetIdUser _getIdUser { get; }
        public ProductoesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IGetIdUser getIdUser)
        {
            _context = context;
            _userManager = userManager;
            _getIdUser = getIdUser;
        }



        // GET: api/Productoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            //var claims = User.Claims.ToList();
            //var idUsuario_Token = claims.FirstOrDefault(x => x.Type == "wUs7");
            var user = _getIdUser.GetIdUserId();


            return await _context.Productos.Where(x => x.ApplicationUser.Id == user).ToListAsync();

        }

        // GET: api/Productoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        // PUT: api/Productoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            producto.rutaImagen = "Update/" + producto.rutaImagen;
            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Productoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            var claims = User.Claims.ToList();
            var idUsuario_Token = claims.FirstOrDefault(x => x.Type == "wUs7");
            producto.ApplicationUserID = idUsuario_Token.Value;
            producto.rutaImagen = "Update/" + producto.rutaImagen;
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducto", new { id = producto.Id }, producto);
        }

        // DELETE: api/Productoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Producto>> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return producto;
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
