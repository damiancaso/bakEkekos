using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Keyless]
public partial class VwUsuario
{
    [Column("id_Usuario")]
    public int IdUsuario { get; set; }

    [StringLength(100)]
    public string? NombrePersona { get; set; }

    [StringLength(100)]
    public string? ApellidoPaterno { get; set; }

    [StringLength(100)]
    public string? ApellidoMaterno { get; set; }

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

    public string? Rol { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string Estado { get; set; } = null!;

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
}
