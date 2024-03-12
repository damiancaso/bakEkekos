using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Cargo")]
public partial class Cargo
{
    [Key]
    [Column("idCargo")]
    public int IdCargo { get; set; }

    public string? Nombre { get; set; }

    [InverseProperty("IdCargoNavigation")]
    public virtual ICollection<Colaborador> Colaboradors { get; set; } = new List<Colaborador>();
}
