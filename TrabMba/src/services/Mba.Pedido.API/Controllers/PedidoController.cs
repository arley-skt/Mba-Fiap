using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mba.Pedido.API.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
