using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Rol")]
public partial class Rol
{
    [Key]
    [Column("id_Rol")]
    public int IdRol { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("funcion")]
    [StringLength(100)]
    public string? Funcion { get; set; }

    [Column("id_estado")]
    public bool? IdEstado { get; set; }

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
