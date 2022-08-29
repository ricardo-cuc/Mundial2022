using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mundial2022.Entidades
{
    public partial class QUINIELAContext : DbContext
    {
        public QUINIELAContext()
        {
        }

        public QUINIELAContext(DbContextOptions<QUINIELAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AjustesPuntaje> AjustesPuntajes { get; set; }
        public virtual DbSet<ApuestasUsuario> ApuestasUsuarios { get; set; }
        public virtual DbSet<Campeonato> Campeonatos { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<EquiposCampeonato> EquiposCampeonatos { get; set; }
        public virtual DbSet<Estadio> Estadios { get; set; }
        public virtual DbSet<Fase> Fases { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<JugEqCamp> JugEqCamps { get; set; }
        public virtual DbSet<JugPartido> JugPartidos { get; set; }
        public virtual DbSet<Jugador> Jugadors { get; set; }
        public virtual DbSet<Partido> Partidos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LGTAUXIT0656\\SQLEXPRESS; Database=QUINIELA; Trusted_Connection=True;TrustServerCertificate=True;;MultipleactiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AjustesPuntaje>(entity =>
            {
                entity.HasKey(e => e.AId)
                    .HasName("PK__AJUSTES___71AC6D4159C96627");

                entity.ToTable("AJUSTES_PUNTAJE");

                entity.Property(e => e.AId)
                    .ValueGeneratedNever()
                    .HasColumnName("A_ID");

                entity.Property(e => e.APuntajeEmpate).HasColumnName("A_PUNTAJE_EMPATE");

                entity.Property(e => e.APuntajeVictoria).HasColumnName("A_PUNTAJE_VICTORIA");
            });

            modelBuilder.Entity<ApuestasUsuario>(entity =>
            {
                entity.HasKey(e => e.NroApuetas)
                    .HasName("PK__APUESTAS__44470D6DE298E638");

                entity.ToTable("APUESTAS_USUARIOS");

                entity.Property(e => e.NroApuetas).HasColumnName("NRO_APUETAS");

                entity.Property(e => e.APuntosCanjeados).HasColumnName("A_PUNTOS_CANJEADOS");

                entity.Property(e => e.AResultadoE1).HasColumnName("A_RESULTADO_E1");

                entity.Property(e => e.AResultadoE2).HasColumnName("A_RESULTADO_E2");

                entity.Property(e => e.ATipoResultado).HasColumnName("A_TIPO_RESULTADO");

                entity.Property(e => e.NroPartido).HasColumnName("NRO_PARTIDO");

                entity.Property(e => e.UCodigo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("U_CODIGO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.NroPartidoNavigation)
                    .WithMany(p => p.ApuestasUsuarios)
                    .HasForeignKey(d => d.NroPartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APUESTAS___NRO_P__4D94879B");

                entity.HasOne(d => d.UCodigoNavigation)
                    .WithMany(p => p.ApuestasUsuarios)
                    .HasForeignKey(d => d.UCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APUESTAS___U_COD__4E88ABD4");
            });

            modelBuilder.Entity<Campeonato>(entity =>
            {
                entity.HasKey(e => e.CCampeonato)
                    .HasName("PK__CAMPEONA__0F26C2A814A68771");

                entity.ToTable("CAMPEONATO");

                entity.Property(e => e.CCampeonato)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_CAMPEONATO")
                    .IsFixedLength(true);

                entity.Property(e => e.NCampeonato)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_CAMPEONATO");

                entity.Property(e => e.QPartidos).HasColumnName("Q_PARTIDOS");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.CEquipo)
                    .HasName("PK__EQUIPO__93A808468C45FB42");

                entity.ToTable("EQUIPO");

                entity.Property(e => e.CEquipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO")
                    .IsFixedLength(true);

                entity.Property(e => e.Banderas)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANDERAS");

                entity.Property(e => e.ENombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("E_NOMBRE");

                entity.Property(e => e.NEquipo)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_EQUIPO");

                entity.Property(e => e.UrlBandera)
                    .IsUnicode(false)
                    .HasColumnName("URL_BANDERA");
            });

            modelBuilder.Entity<EquiposCampeonato>(entity =>
            {
                entity.HasKey(e => new { e.ECId, e.CEquipo, e.CCampeonato })
                    .HasName("PK__EQUIPOS___B5F0BEEFBF1CEA53");

                entity.ToTable("EQUIPOS_CAMPEONATO");

                entity.Property(e => e.ECId).HasColumnName("E_C_ID");

                entity.Property(e => e.CEquipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO")
                    .IsFixedLength(true);

                entity.Property(e => e.CCampeonato)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_CAMPEONATO")
                    .IsFixedLength(true);

                entity.Property(e => e.ETotalPuntos).HasColumnName("E_TOTAL_PUNTOS");

                entity.HasOne(d => d.CCampeonatoNavigation)
                    .WithMany(p => p.EquiposCampeonatos)
                    .HasForeignKey(d => d.CCampeonato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EQUIPOS_C__C_CAM__4F7CD00D");

                entity.HasOne(d => d.CEquipoNavigation)
                    .WithMany(p => p.EquiposCampeonatos)
                    .HasForeignKey(d => d.CEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EQUIPOS_C__C_EQU__5070F446");
            });

            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.CEstadio)
                    .HasName("PK__ESTADIO__45173E5B014805AA");

                entity.ToTable("ESTADIO");

                entity.Property(e => e.CEstadio)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_ESTADIO")
                    .IsFixedLength(true);

                entity.Property(e => e.NEstadio)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_ESTADIO");
            });

            modelBuilder.Entity<Fase>(entity =>
            {
                entity.ToTable("FASE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PK__GRUPOS__B507857749545B14");

                entity.ToTable("GRUPOS");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_GRUPO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<JugEqCamp>(entity =>
            {
                entity.HasKey(e => new { e.CJugador, e.CCampeonato })
                    .HasName("PK__JUG_EQ_C__473F0F2A2CADB38A");

                entity.ToTable("JUG_EQ_CAMP");

                entity.Property(e => e.CJugador)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_JUGADOR")
                    .IsFixedLength(true);

                entity.Property(e => e.CCampeonato)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_CAMPEONATO")
                    .IsFixedLength(true);

                entity.Property(e => e.CEquipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CCampeonatoNavigation)
                    .WithMany(p => p.JugEqCamps)
                    .HasForeignKey(d => d.CCampeonato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_EQ_CA__C_CAM__5165187F");

                entity.HasOne(d => d.CEquipoNavigation)
                    .WithMany(p => p.JugEqCamps)
                    .HasForeignKey(d => d.CEquipo)
                    .HasConstraintName("FK__JUG_EQ_CA__C_EQU__52593CB8");

                entity.HasOne(d => d.CJugadorNavigation)
                    .WithMany(p => p.JugEqCamps)
                    .HasForeignKey(d => d.CJugador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_EQ_CA__C_JUG__534D60F1");
            });

            modelBuilder.Entity<JugPartido>(entity =>
            {
                entity.HasKey(e => new { e.CJugador, e.NroPartido })
                    .HasName("PK__JUG_PART__FE1852F5D9FF0287");

                entity.ToTable("JUG_PARTIDO");

                entity.Property(e => e.CJugador)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_JUGADOR")
                    .IsFixedLength(true);

                entity.Property(e => e.NroPartido).HasColumnName("NRO_PARTIDO");

                entity.Property(e => e.FAmonestado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("F_AMONESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.FExpulsado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("F_EXPULSADO")
                    .IsFixedLength(true);

                entity.Property(e => e.FGoleador)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("F_GOLEADOR")
                    .IsFixedLength(true);

                entity.Property(e => e.NPosicion)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_POSICION");

                entity.Property(e => e.NroCamiseta).HasColumnName("NRO_CAMISETA");

                entity.HasOne(d => d.CJugadorNavigation)
                    .WithMany(p => p.JugPartidos)
                    .HasForeignKey(d => d.CJugador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_PARTI__C_JUG__5441852A");

                entity.HasOne(d => d.NroPartidoNavigation)
                    .WithMany(p => p.JugPartidos)
                    .HasForeignKey(d => d.NroPartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_PARTI__NRO_P__5535A963");
            });

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.HasKey(e => e.CJugador)
                    .HasName("PK__JUGADOR__D7CD630065C23BC7");

                entity.ToTable("JUGADOR");

                entity.Property(e => e.CJugador)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_JUGADOR")
                    .IsFixedLength(true);

                entity.Property(e => e.DNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("D_NACIMIENTO");

                entity.Property(e => e.NJugador)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_JUGADOR");
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasKey(e => e.NroPartido)
                    .HasName("PK__PARTIDO__9D531F533FE1FED1");

                entity.ToTable("PARTIDO");

                entity.Property(e => e.NroPartido)
                    .ValueGeneratedNever()
                    .HasColumnName("NRO_PARTIDO");

                entity.Property(e => e.CCampeonato)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_CAMPEONATO")
                    .IsFixedLength(true);

                entity.Property(e => e.CEquipo1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO_1")
                    .IsFixedLength(true);

                entity.Property(e => e.CEquipo2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO_2")
                    .IsFixedLength(true);

                entity.Property(e => e.CEstadioPart)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_ESTADIO_PART")
                    .IsFixedLength(true);

                entity.Property(e => e.EPartido)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("E_PARTIDO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.IdFase).HasColumnName("ID_FASE");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_GRUPO");

                entity.Property(e => e.NArbitro)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_ARBITRO");

                entity.Property(e => e.QGolesE1).HasColumnName("Q_GOLES_E1");

                entity.Property(e => e.QGolesE2).HasColumnName("Q_GOLES_E2");

                entity.HasOne(d => d.CCampeonatoNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.CCampeonato)
                    .HasConstraintName("FK__PARTIDO__C_CAMPE__5629CD9C");

                entity.HasOne(d => d.CEquipo1Navigation)
                    .WithMany(p => p.PartidoCEquipo1Navigations)
                    .HasForeignKey(d => d.CEquipo1)
                    .HasConstraintName("FK__PARTIDO__C_EQUIP__571DF1D5");

                entity.HasOne(d => d.CEquipo2Navigation)
                    .WithMany(p => p.PartidoCEquipo2Navigations)
                    .HasForeignKey(d => d.CEquipo2)
                    .HasConstraintName("FK__PARTIDO__C_EQUIP__5812160E");

                entity.HasOne(d => d.CEstadioPartNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.CEstadioPart)
                    .HasConstraintName("FK__PARTIDO__C_ESTAD__59063A47");

                entity.HasOne(d => d.IdFaseNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.IdFase)
                    .HasConstraintName("FK__PARTIDO__ID_FASE__59FA5E80");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("ID_GRUPO");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UCodigo)
                    .HasName("PK__USUARIOS__E9817A8323B73D3E");

                entity.ToTable("USUARIOS");

                entity.Property(e => e.UCodigo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("U_CODIGO")
                    .IsFixedLength(true);

                entity.Property(e => e.UApellido)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("U_APELLIDO");

                entity.Property(e => e.UCorreo)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("U_CORREO");

                entity.Property(e => e.UNombre)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("U_NOMBRE");

                entity.Property(e => e.UPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("U_PASSWORD");

                entity.Property(e => e.UPuntosTotales).HasColumnName("U_PUNTOS_TOTALES");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
