using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class MenuRolResponse
    {
        [Key]
        [Column("id_menu_rol")]
        public int IdMenuRol { get; set; }

        [Column("id_rol")]
        public int? IdRol { get; set; }

        [Column("id_menu")]
        public int? IdMenu { get; set; }

        [Column("id_status")]
        public int? IdStatus { get; set; }

        [Column("usuario_crea")]
        [StringLength(50)]
        public string? UsuarioCrea { get; set; }

        [Column("usuario_actualiza")]
        [StringLength(50)]
        public string? UsuarioActualiza { get; set; }

        [Column("fecha_crea", TypeName = "datetime")]
        public DateTime? FechaCrea { get; set; }

        [Column("fecha_actualiza", TypeName = "datetime")]
        public DateTime? FechaActualiza { get; set; }
    }
}
