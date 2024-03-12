using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Pedido")]
public partial class Pedido
{
    [Key]
    [Column("id_pedido")]
    public int IdPedido { get; set; }

    [Column("hora_fecha_pedido", TypeName = "datetime")]
    public DateTime? HoraFechaPedido { get; set; }

    [Column("hora_fecha_llegada", TypeName = "datetime")]
    public DateTime? HoraFechaLlegada { get; set; }

    [Column("nro_comensales")]
    public int? NroComensales { get; set; }

    [Column("id_colaborador")]
    public int? IdColaborador { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("id_metodo_pago")]
    public int? IdMetodoPago { get; set; }

    [Column("id_mesa")]
    public int? IdMesa { get; set; }

    [InverseProperty("IdPedidoNavigation")]
    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    [ForeignKey("IdColaborador")]
    [InverseProperty("Pedidos")]
    public virtual Colaborador? IdColaboradorNavigation { get; set; }

    [ForeignKey("IdMesa")]
    [InverseProperty("Pedidos")]
    public virtual Mesa? IdMesaNavigation { get; set; }

    [ForeignKey("IdMetodoPago")]
    [InverseProperty("Pedidos")]
    public virtual MetodoPago? IdMetodoPagoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Pedidos")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
