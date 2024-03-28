using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class PersonaTipoDocumentoResponse
    {
        [Key]
        [Column("id_person_tipo_documento")]
        public int IdPersonTipoDocumento { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("id_stado")]
        public bool? IdStado { get; set; }
    }
}
