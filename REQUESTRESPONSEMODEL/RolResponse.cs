using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class RolResponse
    {
        [Key]
        [Column("id_Rol")]
        public int IdRol { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("funcion")]
        [StringLength(100)]
        public string? Funcion { get; set; }

        [Column("id_estado")]
        public bool? IdEstado { get; set; }

    }
}
