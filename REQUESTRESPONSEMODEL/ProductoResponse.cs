using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class ProductoResponse
    {
        [Key]
        [Column("id_producto")]
        public int IdProducto { get; set; }

        [Column("isproducto")]
        [StringLength(100)]
        public string? Isproducto { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        public int? Stock { get; set; }

        [Column("Stock_minimo")]
        public int? StockMinimo { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("precio", TypeName = "decimal(18, 2)")]
        public decimal? Precio { get; set; }

        [Column("id_Categoria")]
        public int? IdCategoria { get; set; }

        [Column("url_imagen")]
        public string? UrlImagen { get; set; }

    }
}
