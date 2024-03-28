using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class ColaboradorResponse
    {
        public int IdColaborador { get; set; }

        public int? IdEstado { get; set; }

        public string? UsuarioCrea { get; set; }

        public string? UsuarioActualiza { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? IdCargo { get; set; }

        public int? IdPersona { get; set; }
    }
}
