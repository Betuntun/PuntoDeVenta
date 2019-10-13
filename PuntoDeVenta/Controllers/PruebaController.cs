using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public PruebaController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;

            _userManager = userManager;
        }

       
        [HttpGet]
        public ActionResult GetUsuarioActual()
        {
            //esta prueba era para ver si se podia obtener el usuario actual
            var currentUserId = _userManager.GetUserId(HttpContext.User);
            //return await _context.Productos.Where(x => x.ApplicationUser.Id == idUsuario_Token.Value).ToListAsync();
            return Ok(currentUserId);

        }
    }
}