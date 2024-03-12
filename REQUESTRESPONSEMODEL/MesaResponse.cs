using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class MesaResponse
    {
        [Key]
        [Column("idMesa")]
        public int IdMesa { get; set; }

        [Column("Nro_asientos")]
        public int? NroAsientos { get; set; }
    }
}
