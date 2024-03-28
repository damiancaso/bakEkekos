using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    [Column("id_Usuario")]
    public int IdUsuario { get; set; }

    [Column("Id_persona")]
    public int IdPersona { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Pasword { get; set; } = null!;

    [Column("change_paswword")]
    [StringLength(50)]
    [Unicode(false)]
    public string ChangePaswword { get; set; } = null!;

    [Column("email")]
    [StringLength(90)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("id_rol")]
    public int IdRol { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [Column("usuario_crea")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioCrea { get; set; } = null!;

    [Column("usuario_actualiza")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsuarioActualiza { get; set; } = null!;

    [Column("fecha_crea", TypeName = "datetime")]
    public DateTime FechaCrea { get; set; }

    [Column("fecha_actualiza", TypeName = "datetime")]
    public DateTime FechaActualiza { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    [InverseProperty("UsuarioActualizaNavigation")]
    public virtual ICollection<Error> ErrorUsuarioActualizaNavigations { get; set; } = new List<Error>();

    [InverseProperty("UsuarioCreaNavigation")]
    public virtual ICollection<Error> ErrorUsuarioCreaNavigations { get; set; } = new List<Error>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Usuarios")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdRol")]
    [InverseProperty("Usuarios")]
    public virtual Rol IdRolNavigation { get; set; } = null!;

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<UserSesion> UserSesions { get; set; } = new List<UserSesion>();
}
