using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Producto")]
public partial class Producto
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

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    [ForeignKey("IdCategoria")]
    [InverseProperty("Productos")]
    public virtual ProductoCategorium? IdCategoriaNavigation { get; set; }
}
