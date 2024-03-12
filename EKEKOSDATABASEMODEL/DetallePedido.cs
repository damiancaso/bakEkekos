using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Detalle_Pedido")]
public partial class DetallePedido
{
    [Key]
    [Column("id_detalle_pedido")]
    public int IdDetallePedido { get; set; }

    [Column("id_pedido")]
    public int? IdPedido { get; set; }

    [Column("id_producto")]
    public int? IdProducto { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("DetallePedidos")]
    public virtual Pedido? IdPedidoNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetallePedidos")]
    public virtual Producto? IdProductoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("DetallePedidos")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
