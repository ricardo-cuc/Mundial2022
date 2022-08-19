﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mundial2022.Models
{
    public partial class MundialClubesContext : DbContext
    {
        public MundialClubesContext()
        {
        }

        public MundialClubesContext(DbContextOptions<MundialClubesContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AjustesPuntaje> AjustesPuntajes { get; set; }
        public virtual DbSet<ApuestasUsuario> ApuestasUsuarios { get; set; }
        public virtual DbSet<Campeonato> Campeonatos { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<EquiposCampeonato> EquiposCampeonatos { get; set; }
        public virtual DbSet<Estadio> Estadios { get; set; }
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
                optionsBuilder.UseSqlServer("Server=LGTAUXIT0656\\SQLEXPRESS; Database=MundialClubes; Trusted_Connection=True;TrustServerCertificate=True;;MultipleactiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AjustesPuntaje>(entity =>
            {
                entity.HasKey(e => e.AId)
                    .HasName("PK__AJUSTES___71AC6D413FCABA68");

                entity.ToTable("AJUSTES_PUNTAJE");

                entity.Property(e => e.AId)
                    .ValueGeneratedNever()
                    .HasColumnName("A_ID");

                entity.Property(e => e.APuntajeEmpate).HasColumnName("A_PUNTAJE_EMPATE");

                entity.Property(e => e.APuntajeVictoria).HasColumnName("A_PUNTAJE_VICTORIA");
            });

            modelBuilder.Entity<ApuestasUsuario>(entity =>
            {
                entity.HasKey(e => new { e.NroApuetas, e.NroPartido, e.UCodigo })
                    .HasName("PK__APUESTAS__EF7BBDE258236735");

                entity.ToTable("APUESTAS_USUARIOS");

                entity.Property(e => e.NroApuetas)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NRO_APUETAS")
                    .IsFixedLength(true);

                entity.Property(e => e.NroPartido).HasColumnName("NRO_PARTIDO");

                entity.Property(e => e.UCodigo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("U_CODIGO")
                    .IsFixedLength(true);

                entity.Property(e => e.APuntosCanjeados).HasColumnName("A_PUNTOS_CANJEADOS");

                entity.Property(e => e.AResultadoE1).HasColumnName("A_RESULTADO_E1");

                entity.Property(e => e.AResultadoE2).HasColumnName("A_RESULTADO_E2");

                entity.Property(e => e.ATipoResultado).HasColumnName("A_TIPO_RESULTADO");

                entity.HasOne(d => d.NroPartidoNavigation)
                    .WithMany(p => p.ApuestasUsuarios)
                    .HasForeignKey(d => d.NroPartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APUESTAS___NRO_P__71D1E811");

                entity.HasOne(d => d.UCodigoNavigation)
                    .WithMany(p => p.ApuestasUsuarios)
                    .HasForeignKey(d => d.UCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APUESTAS___U_COD__72C60C4A");
            });

            modelBuilder.Entity<Campeonato>(entity =>
            {
                entity.HasKey(e => e.CCampeonato)
                    .HasName("PK__CAMPEONA__0F26C2A871F5B10B");

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
                    .HasName("PK__EQUIPO__93A80846DC0267FE");

                entity.ToTable("EQUIPO");

                entity.Property(e => e.CEquipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("C_EQUIPO")
                    .IsFixedLength(true);

                entity.Property(e => e.ENombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("E_NOMBRE");

                entity.Property(e => e.NEquipo)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_EQUIPO");
            });

            modelBuilder.Entity<EquiposCampeonato>(entity =>
            {
                entity.HasKey(e => new { e.ECId, e.CEquipo, e.CCampeonato })
                    .HasName("PK__EQUIPOS___B5F0BEEFC160CAC2");

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
                    .HasConstraintName("FK__EQUIPOS_C__C_CAM__01142BA1");

                entity.HasOne(d => d.CEquipoNavigation)
                    .WithMany(p => p.EquiposCampeonatos)
                    .HasForeignKey(d => d.CEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EQUIPOS_C__C_EQU__00200768");
            });

            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.CEstadio)
                    .HasName("PK__ESTADIO__45173E5BE3264F26");

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

            modelBuilder.Entity<JugEqCamp>(entity =>
            {
                entity.HasKey(e => new { e.CJugador, e.CCampeonato })
                    .HasName("PK__JUG_EQ_C__473F0F2ACEB9236F");

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
                    .HasConstraintName("FK__JUG_EQ_CA__C_CAM__3D5E1FD2");

                entity.HasOne(d => d.CEquipoNavigation)
                    .WithMany(p => p.JugEqCamps)
                    .HasForeignKey(d => d.CEquipo)
                    .HasConstraintName("FK__JUG_EQ_CA__C_EQU__3E52440B");

                entity.HasOne(d => d.CJugadorNavigation)
                    .WithMany(p => p.JugEqCamps)
                    .HasForeignKey(d => d.CJugador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_EQ_CA__C_JUG__3C69FB99");
            });

            modelBuilder.Entity<JugPartido>(entity =>
            {
                entity.HasKey(e => new { e.CJugador, e.NroPartido })
                    .HasName("PK__JUG_PART__FE1852F5015531DD");

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
                    .HasConstraintName("FK__JUG_PARTI__C_JUG__48CFD27E");

                entity.HasOne(d => d.NroPartidoNavigation)
                    .WithMany(p => p.JugPartidos)
                    .HasForeignKey(d => d.NroPartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUG_PARTI__NRO_P__49C3F6B7");
            });

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.HasKey(e => e.CJugador)
                    .HasName("PK__JUGADOR__D7CD63003F3918F9");

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
                    .HasName("PK__PARTIDO__9D531F533A521848");

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

                entity.Property(e => e.DPartido)
                    .HasColumnType("date")
                    .HasColumnName("D_PARTIDO");

                entity.Property(e => e.EPartido)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("E_PARTIDO");

                entity.Property(e => e.NArbitro)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("N_ARBITRO");

                entity.Property(e => e.NJuezLinea1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("N_JUEZ_LINEA1");

                entity.Property(e => e.NJuezLinea2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("N_JUEZ_LINEA2");

                entity.Property(e => e.QGolesE1).HasColumnName("Q_GOLES_E1");

                entity.Property(e => e.QGolesE2).HasColumnName("Q_GOLES_E2");

                entity.HasOne(d => d.CCampeonatoNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.CCampeonato)
                    .HasConstraintName("FK__PARTIDO__C_CAMPE__45F365D3");

                entity.HasOne(d => d.CEquipo1Navigation)
                    .WithMany(p => p.PartidoCEquipo1Navigations)
                    .HasForeignKey(d => d.CEquipo1)
                    .HasConstraintName("FK__PARTIDO__C_EQUIP__440B1D61");

                entity.HasOne(d => d.CEquipo2Navigation)
                    .WithMany(p => p.PartidoCEquipo2Navigations)
                    .HasForeignKey(d => d.CEquipo2)
                    .HasConstraintName("FK__PARTIDO__C_EQUIP__44FF419A");

                entity.HasOne(d => d.CEstadioPartNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.CEstadioPart)
                    .HasConstraintName("FK__PARTIDO__C_ESTAD__4316F928");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UCodigo)
                    .HasName("PK__USUARIOS__E9817A83558EE488");

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
                    .HasColumnType("text")
                    .HasColumnName("U_PASSWORD");

                entity.Property(e => e.UPuntosTotales).HasColumnName("U_PUNTOS_TOTALES");
            });

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public static implicit operator string(MundialClubesContext v)
        {
            throw new NotImplementedException();
        }
    }
}