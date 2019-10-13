using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

using System.Net;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Controllers
{
    public interface IGetIdUser
    {
        string GetIdUserId();
    }

    public class GetIdUser : IGetIdUser
    {



        private IHttpContextAccessor _accessor;
        public GetIdUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string GetIdUserId()
        {
            var identity = _accessor.HttpContext.User.Identity;
            if (identity.IsAuthenticated)
            {
               var claims = _accessor.HttpContext.User.Claims.ToList();
                var idUsuario_Token = claims.FirstOrDefault(x => x.Type == "wUs7");
                //return _accessor.HttpContext.User
                // .FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
                return idUsuario_Token.Value;
            }
            else
            {
                return Guid.Empty.ToString();
            }
        }
    }
}
