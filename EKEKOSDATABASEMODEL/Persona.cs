using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

[Table("Persona")]
public partial class Persona
{
    [Key]
    [Column("id_persona")]
    public int IdPersona { get; set; }

    [Column("id_person_tipo_documento")]
    public int? IdPersonTipoDocumento { get; set; }

    [Column("Nro_documento")]
    [StringLength(50)]
    public string? NroDocumento { get; set; }

    [StringLength(100)]
    public string? Nombre { get; set; }

    [Column("Ap_Paterno")]
    [StringLength(100)]
    public string? ApPaterno { get; set; }

    [Column("Ap_Materno")]
    [StringLength(100)]
    public string? ApMaterno { get; set; }

    [Column("Nombre_completo")]
    [StringLength(300)]
    public string? NombreCompleto { get; set; }

    [Column("Fecha_nacimiento")]
    public DateOnly? FechaNacimiento { get; set; }

    [Column("Id_genero")]
    public int? IdGenero { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Celular { get; set; }

    [Column("Usuario_crea")]
    [StringLength(50)]
    public string? UsuarioCrea { get; set; }

    [Column("Usuario_actualiza")]
    [StringLength(50)]
    public string? UsuarioActualiza { get; set; }

    [Column("Fecha_crea", TypeName = "datetime")]
    public DateTime? FechaCrea { get; set; }

    [Column("Fecha_Actualiza", TypeName = "datetime")]
    public DateTime? FechaActualiza { get; set; }

    [Column("id_person_tipo")]
    public int? IdPersonTipo { get; set; }

    [Column("id_ubica")]
    public int? IdUbica { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Colaborador> Colaboradors { get; set; } = new List<Colaborador>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

    [ForeignKey("IdGenero")]
    [InverseProperty("Personas")]
    public virtual PersonaGenero? IdGeneroNavigation { get; set; }

    [ForeignKey("IdPersonTipoDocumento")]
    [InverseProperty("Personas")]
    public virtual PersonaTipoDocumento? IdPersonTipoDocumentoNavigation { get; set; }

    [ForeignKey("IdPersonTipo")]
    [InverseProperty("Personas")]
    public virtual PersonTipo? IdPersonTipoNavigation { get; set; }

    [ForeignKey("IdUbica")]
    [InverseProperty("Personas")]
    public virtual UbicacionGeo? IdUbicaNavigation { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
