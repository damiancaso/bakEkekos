using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class LoginResponse
    {
        public bool Success { get; set; } = false;
        public string Mensaje { get; set; } = "Usuario y/o Password incorectos";
        public UsuarioLoginResponse? usuario { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string TokenExpira { get; set; } = "";
        public string RefreshToken { get; set; } = "";
        public RolResponse? Rol { get; set; } = null;
        public PersonaResponse? Persona { get; set; } = null;

    }
}
