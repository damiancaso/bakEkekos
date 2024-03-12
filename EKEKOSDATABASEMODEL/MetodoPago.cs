using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Metodo_Pago")]
public partial class MetodoPago
{
    [Key]
    [Column("idMetodo")]
    public int IdMetodo { get; set; }

    [StringLength(100)]
    public string? Nombre { get; set; }

    [InverseProperty("IdMetodoPagoNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
