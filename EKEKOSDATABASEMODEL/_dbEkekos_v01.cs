using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EKEKOSDATABASEMODEL;

public partial class _dbEkekos_v01 : DbContext
{
    public _dbEkekos_v01()
    {
    }

    public _dbEkekos_v01(DbContextOptions<_dbEkekos_v01> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Colaborador> Colaboradors { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<Mesa> Mesas { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PersonTipo> PersonTipos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonaGenero> PersonaGeneros { get; set; }

    public virtual DbSet<PersonaTipoDocumento> PersonaTipoDocumentos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoCategorium> ProductoCategoria { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<UbicacionGeo> UbicacionGeos { get; set; }

    public virtual DbSet<UserSesion> UserSesions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VwPersona> VwPersonas { get; set; }

    public virtual DbSet<VwUsuario> VwUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=ekekov03.mssql.somee.com;persist security info=False;initial catalog=ekekov03;user id=JoseT_SQLLogin_1;pwd=nxusthytor;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__Cargo__3D0E29B81D209680");
        });

        modelBuilder.Entity<Colaborador>(entity =>
        {
            entity.HasKey(e => e.IdColaborador).HasName("PK__Colabora__A6A5C396FFE93D0A");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Colaboradors).HasConstraintName("FK__Colaborad__idCar__5AEE82B9");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Colaboradors).HasConstraintName("FK__Colaborad__id_pe__59FA5E80");
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => e.IdDetallePedido).HasName("PK__Detalle___C08768CF9783EED8");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.DetallePedidos).HasConstraintName("FK__Detalle_P__id_pe__5BE2A6F2");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetallePedidos).HasConstraintName("FK__Detalle_P__id_pr__5CD6CB2B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.DetallePedidos).HasConstraintName("FK__Detalle_P__id_us__5DCAEF64");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__error__3213E83F289CC306");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Errors).HasConstraintName("FK__error__id_person__5EBF139D");

            entity.HasOne(d => d.UsuarioActualizaNavigation).WithMany(p => p.ErrorUsuarioActualizaNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__error__usuario_a__5FB337D6");

            entity.HasOne(d => d.UsuarioCreaNavigation).WithMany(p => p.ErrorUsuarioCreaNavigations).HasConstraintName("FK__error__usuario_c__60A75C0F");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__Menu__68A1D9DB489322D2");
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.IdMenuRol).HasName("PK__Menu_rol__E24FCDD8108C4DA8");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols).HasConstraintName("FK__Menu_rol__id_men__619B8048");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRols).HasConstraintName("FK__Menu_rol__id_rol__628FA481");
        });

        modelBuilder.Entity<Mesa>(entity =>
        {
            entity.HasKey(e => e.IdMesa).HasName("PK__Mesa__C26D1DFF5ED7D076");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodo).HasName("PK__Metodo_P__E123E7E6287A54D1");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedido__6FF01489577CAB6F");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedido__id_colab__6383C8BA");

            entity.HasOne(d => d.IdMesaNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedido__id_mesa__6477ECF3");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedido__id_metod__656C112C");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Pedidos).HasConstraintName("FK__Pedido__id_usuar__66603565");
        });

        modelBuilder.Entity<PersonTipo>(entity =>
        {
            entity.HasKey(e => e.IdPersonTipo).HasName("PK__Person_t__E1BF43E559029267");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__Persona__228148B01B9DCC93");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Personas).HasConstraintName("FK__Persona__Id_gene__6754599E");

            entity.HasOne(d => d.IdPersonTipoNavigation).WithMany(p => p.Personas).HasConstraintName("FK__Persona__id_pers__693CA210");

            entity.HasOne(d => d.IdPersonTipoDocumentoNavigation).WithMany(p => p.Personas).HasConstraintName("FK__Persona__id_pers__68487DD7");

            entity.HasOne(d => d.IdUbicaNavigation).WithMany(p => p.Personas).HasConstraintName("FK__Persona__id_ubic__6A30C649");
        });

        modelBuilder.Entity<PersonaGenero>(entity =>
        {
            entity.HasKey(e => e.IdGenero).HasName("PK__Persona___3D0DF48665502784");
        });

        modelBuilder.Entity<PersonaTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdPersonTipoDocumento).HasName("PK__Persona___55C489D88BF14D32");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__FF341C0D25009B16");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos).HasConstraintName("FK__Producto__id_Cat__6B24EA82");
        });

        modelBuilder.Entity<ProductoCategorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Producto__CD54BC5A5E40B56D");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__76482FD28DA3B958");
        });

        modelBuilder.Entity<UbicacionGeo>(entity =>
        {
            entity.HasKey(e => e.IdUbica).HasName("PK__Ubicacio__3704E381DF76D507");
        });

        modelBuilder.Entity<UserSesion>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__User_ses__D2D14637325DE61B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UserSesions).HasConstraintName("FK__User_sesi__id_us__6C190EBB");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__8E901EAA3CA80C28");

            entity.Property(e => e.IdUsuario).ValueGeneratedNever();

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__Id_pers__6D0D32F4");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__id_rol__6E01572D");
        });

        modelBuilder.Entity<VwPersona>(entity =>
        {
            entity.ToView("vw_Persona");
        });

        modelBuilder.Entity<VwUsuario>(entity =>
        {
            entity.ToView("vw_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
