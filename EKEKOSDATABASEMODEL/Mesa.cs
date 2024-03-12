using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Mesa")]
public partial class Mesa
{
    [Key]
    [Column("idMesa")]
    public int IdMesa { get; set; }

    [Column("Nro_asientos")]
    public int? NroAsientos { get; set; }

    [InverseProperty("IdMesaNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
