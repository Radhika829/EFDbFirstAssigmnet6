using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDBFirstAssignment5.Models
{
    public partial class PlayersTeamContext : DbContext
    {
        public PlayersTeamContext()
        {
        }

        public PlayersTeamContext(DbContextOptions<PlayersTeamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=RADHIKAGOWDA;database=PlayersTeam;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.PlayersId)
                    .HasName("PK__Player__9BD582EE28082AF7");

                entity.ToTable("Player");

                entity.Property(e => e.PlayersId).ValueGeneratedNever();

                entity.Property(e => e.FisrtName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Team)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
