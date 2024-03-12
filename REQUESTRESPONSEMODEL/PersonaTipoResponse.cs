using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class PersonaTipoResponse
    {
        [Key]
        [Column("id_person_tipo")]
        public int IdPersonTipo { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

    }
}
