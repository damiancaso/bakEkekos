using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class UsuarioResponse
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public string Username { get; set; } = null!;
        public string Pasword { get; set; } = null!;
        public string ChangePaswword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int IdRol { get; set; }
        public bool IdEstado { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public string UsuarioActualiza { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public DateTime FechaActualiza { get; set; }
    }
}
