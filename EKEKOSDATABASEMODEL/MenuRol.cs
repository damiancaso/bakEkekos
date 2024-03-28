using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Menu_rol")]
public partial class MenuRol
{
    [Key]
    [Column("id_menu_rol")]
    public int IdMenuRol { get; set; }

    [Column("id_rol")]
    public int? IdRol { get; set; }

    [Column("id_menu")]
    public int? IdMenu { get; set; }

    [Column("id_status")]
    public int? IdStatus { get; set; }

    [Column("usuario_crea")]
    [StringLength(50)]
    public string? UsuarioCrea { get; set; }

    [Column("usuario_actualiza")]
    [StringLength(50)]
    public string? UsuarioActualiza { get; set; }

    [Column("fecha_crea", TypeName = "datetime")]
    public DateTime? FechaCrea { get; set; }

    [Column("fecha_actualiza", TypeName = "datetime")]
    public DateTime? FechaActualiza { get; set; }

    [ForeignKey("IdMenu")]
    [InverseProperty("MenuRols")]
    public virtual Menu? IdMenuNavigation { get; set; }

    [ForeignKey("IdRol")]
    [InverseProperty("MenuRols")]
    public virtual Rol? IdRolNavigation { get; set; }
}
