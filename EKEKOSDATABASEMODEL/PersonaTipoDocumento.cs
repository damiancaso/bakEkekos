using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Persona_tipo_documento")]
public partial class PersonaTipoDocumento
{
    [Key]
    [Column("id_person_tipo_documento")]
    public int IdPersonTipoDocumento { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("id_stado")]
    public bool? IdStado { get; set; }

    [InverseProperty("IdPersonTipoDocumentoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
