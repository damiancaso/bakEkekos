using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class MetodoPagoRequest
    {
        [Key]
        [Column("idMetodo")]
        public int IdMetodo { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }
                
    }
}
