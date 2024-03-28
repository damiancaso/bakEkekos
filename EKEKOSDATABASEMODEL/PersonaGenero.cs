using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Persona_genero")]
public partial class PersonaGenero
{
    [Key]
    [Column("Id_genero")]
    public int IdGenero { get; set; }

    [StringLength(100)]
    public string? Nombre { get; set; }

    [InverseProperty("IdGeneroNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
