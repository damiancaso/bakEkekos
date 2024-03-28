using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class MenuRequest
    {
        [Key]
        [Column("id_menu")]
        public int IdMenu { get; set; }

        [Column("nombre")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("icono")]
        [StringLength(100)]
        public string? Icono { get; set; }

        [Column("datatarget")]
        [StringLength(100)]
        public string? Datatarget { get; set; }

        [Column("url")]
        public string? Url { get; set; }

        [Column("padre")]
        public int? Padre { get; set; }

        [Column("id_estado")]
        public bool? IdEstado { get; set; }

        [Column("Usuario_crea")]
        [StringLength(50)]
        public string? UsuarioCrea { get; set; }

        [Column("usuario_actualiza")]
        [StringLength(50)]
        public string? UsuarioActualiza { get; set; }
               
    }
}
