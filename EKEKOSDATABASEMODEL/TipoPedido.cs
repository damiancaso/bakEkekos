using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("tipoPedido")]
public partial class TipoPedido
{
    [Key]
    [Column("idtipopedido")]
    public int Idtipopedido { get; set; }

    [Column("nombre")]
    [StringLength(20)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdTipoPedidoNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
