using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class UbicacionGeoResponse
    {
        [Key]
        [Column("id_ubica")]
        public int IdUbica { get; set; }

        [Column("distrito")]
        [StringLength(100)]
        public string? Distrito { get; set; }

        [Column("provincia")]
        [StringLength(100)]
        public string? Provincia { get; set; }

        [Column("departamento")]
        [StringLength(100)]
        public string? Departamento { get; set; }

        [Column("ubicacion")]
        public string? Ubicacion { get; set; }

        [Column("direccion")]
        public string? Direccion { get; set; }
                
    }
}
