using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class UserSesionResponse
    {
        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("ip")]
        [StringLength(50)]
        public string? Ip { get; set; }

        [Column("browser")]
        [StringLength(100)]
        public string? Browser { get; set; }

        [Column("token")]
        public string? Token { get; set; }

        [Column("token_refresh")]
        public string? TokenRefresh { get; set; }

        [Column("fecha_crea", TypeName = "datetime")]
        public DateTime? FechaCrea { get; set; }

        [Column("fecha_actualiza", TypeName = "datetime")]
        public DateTime? FechaActualiza { get; set; }

        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
    }
}
