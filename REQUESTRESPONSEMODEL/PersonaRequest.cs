using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class PersonaRequest
    {
        public int IdPersona { get; set; }
        public int? IdPersonTipoDocumento { get; set; }
        public string? NroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? ApPaterno { get; set; }
        public string? ApMaterno { get; set; }
        public string? NombreCompleto { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
        public int? IdGenero { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? UsuarioCrea { get; set; }
        public string? UsuarioActualiza { get; set; }
        public DateTime? FechaCrea { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public int? IdPersonTipo { get; set; }
        public int? IdUbica { get; set; }
    }
}
