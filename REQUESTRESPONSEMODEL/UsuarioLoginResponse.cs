using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class UsuarioLoginResponse
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; } = null!;
        public string ApPaterno { get; set; } = null!;
        public string ApMaterno { get; set; } = null!;
        public string NroDocumento { get; set; } = null!;
        public int IdPersona { get; set; }
        public string Username { get; set; } = null!;
        public string Pasword { get; set; } = null!;
    }
}
