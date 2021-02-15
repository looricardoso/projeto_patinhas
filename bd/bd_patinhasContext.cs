using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace projeto_patinhas.bd
{
    public partial class bd_patinhasContext : DbContext
    {
        public bd_patinhasContext()
        {
        }

        public bd_patinhasContext(DbContextOptions<bd_patinhasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbDog> TbDog { get; set; }
        public virtual DbSet<TbRacasDog> TbRacasDog { get; set; }
        public virtual DbSet<TbUsuario> TbUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbDog>(entity =>
            {
                entity.HasKey(e => e.CdDog)
                    .HasName("PRIMARY");

                entity.ToTable("tb_dog");

                entity.HasIndex(e => e.IdRaca)
                    .HasName("id_raca");

                entity.Property(e => e.CdDog).HasColumnName("cd_dog");

                entity.Property(e => e.DsTemperamento)
                    .HasColumnName("ds_temperamento")
                    .HasMaxLength(30);

                entity.Property(e => e.IdRaca).HasColumnName("id_raca");

                entity.Property(e => e.NmDog)
                    .IsRequired()
                    .HasColumnName("nm_dog")
                    .HasMaxLength(30);

                entity.Property(e => e.ObsDog)
                    .HasColumnName("obs_dog")
                    .HasColumnType("longtext");

                entity.Property(e => e.QtIdade).HasColumnName("qt_idade");

                entity.Property(e => e.StCastrado).HasColumnName("st_castrado");

                entity.Property(e => e.StVermifugado).HasColumnName("st_vermifugado");

                entity.Property(e => e.Vacinado).HasColumnName("vacinado");

                entity.HasOne(d => d.IdRacaNavigation)
                    .WithMany(p => p.TbDog)
                    .HasForeignKey(d => d.IdRaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_dog_ibfk_1");
            });

            modelBuilder.Entity<TbRacasDog>(entity =>
            {
                entity.HasKey(e => e.CdRaca)
                    .HasName("PRIMARY");

                entity.ToTable("tb_racas_dog");

                entity.Property(e => e.CdRaca).HasColumnName("cd_raca");

                entity.Property(e => e.NmRaca)
                    .IsRequired()
                    .HasColumnName("nm_raca")
                    .HasMaxLength(50);

                entity.Property(e => e.Porte).HasColumnName("porte");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.CdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("tb_usuario");

                entity.HasIndex(e => e.IdDog)
                    .HasName("id_dog");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.CepEndereco)
                    .IsRequired()
                    .HasColumnName("cep_endereco")
                    .HasMaxLength(9);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(80);

                entity.Property(e => e.Fone)
                    .IsRequired()
                    .HasColumnName("fone")
                    .HasMaxLength(11);

                entity.Property(e => e.IdDog).HasColumnName("id_dog");

                entity.Property(e => e.NmBairro)
                    .IsRequired()
                    .HasColumnName("nm_bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.NmEndereco)
                    .IsRequired()
                    .HasColumnName("nm_endereco")
                    .HasMaxLength(40);

                entity.Property(e => e.NmUsuario)
                    .IsRequired()
                    .HasColumnName("nm_usuario")
                    .HasMaxLength(50);

                entity.Property(e => e.NrEndereco).HasColumnName("nr_endereco");

                entity.Property(e => e.NrSenha)
                    .IsRequired()
                    .HasColumnName("nr_senha")
                    .HasMaxLength(12);

                entity.Property(e => e.SobrenomeUsuario)
                    .IsRequired()
                    .HasColumnName("sobrenome_usuario")
                    .HasMaxLength(70);

                entity.HasOne(d => d.IdDogNavigation)
                    .WithMany(p => p.TbUsuario)
                    .HasForeignKey(d => d.IdDog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_usuario_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
