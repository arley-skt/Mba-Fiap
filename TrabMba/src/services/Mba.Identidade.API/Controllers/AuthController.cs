using Mba.Identidade.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mba.Identidade.API.Controllers
{
    [ApiController]
    [Route("api/identidade")]
    public class AuthController: Controller
    {        
        [HttpPost("Registrar")]
        public  ActionResult Registrar(UsuarioRegistro user)
        {
            if (!ModelState.IsValid) return BadRequest();

            return Ok();
        }
        [HttpPost("Autenticar")]
        public ActionResult Login(UsuarioLogin user)
        {
            if (!ModelState.IsValid) return BadRequest();

            return Ok();
        }
    }
}
