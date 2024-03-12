using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Producto_Categoria")]
public partial class ProductoCategorium
{
    [Key]
    [Column("id_categoria")]
    public int IdCategoria { get; set; }

    [StringLength(100)]
    public string? Nombre { get; set; }

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
