using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Person_tipo")]
public partial class PersonTipo
{
    [Key]
    [Column("id_person_tipo")]
    public int IdPersonTipo { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [InverseProperty("IdPersonTipoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
