using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mba.Identidade.API.Models
{
    public class UsuarioRegistro
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string senha { get; set; }
        [Required]
        public string Confirmacaosenha { get; set; }
    }
}
