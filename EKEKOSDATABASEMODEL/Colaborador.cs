using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Colaborador")]
public partial class Colaborador
{
    [Key]
    [Column("idColaborador")]
    public int IdColaborador { get; set; }

    [Column("idEstado")]
    public int? IdEstado { get; set; }

    [Column("Usuario_crea")]
    [StringLength(50)]
    public string? UsuarioCrea { get; set; }

    [Column("Usuario_actualiza")]
    [StringLength(50)]
    public string? UsuarioActualiza { get; set; }

    [Column("fecha_crea", TypeName = "datetime")]
    public DateTime? FechaCrea { get; set; }

    [Column("Fecha_actualiza", TypeName = "datetime")]
    public DateTime? FechaActualiza { get; set; }

    [Column("idCargo")]
    public int? IdCargo { get; set; }

    [Column("id_persona")]
    public int? IdPersona { get; set; }

    [ForeignKey("IdCargo")]
    [InverseProperty("Colaboradors")]
    public virtual Cargo? IdCargoNavigation { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Colaboradors")]
    public virtual Persona? IdPersonaNavigation { get; set; }

    [InverseProperty("IdColaboradorNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
