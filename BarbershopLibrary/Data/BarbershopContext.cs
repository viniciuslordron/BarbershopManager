using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarbershopLibrary.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BarbershopLibrary.Data
{
    public class BarbershopContext : DbContext
    {
        public BarbershopContext(DbContextOptions<BarbershopContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Barbeiro> Barbeiros { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<AgendamentoDeServico> AgendamentosDeServico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações de relacionamentos 1:1
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Cliente)
                .WithOne(c => c.Usuario)
                .HasForeignKey<Cliente>(c => c.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Barbeiro)
                .WithOne(b => b.Usuario)
                .HasForeignKey<Barbeiro>(b => b.UsuarioId);

            // Chave primária composta na tabela associativa
            modelBuilder.Entity<AgendamentoDeServico>()
                .HasKey(a => new { a.AgendamentoId, a.ServicoId });

            // Configuração para evitar exclusão em cascata conflitante
            modelBuilder.Entity<Agendamento>()
                .HasOne(a => a.Cliente)
                .WithMany(c => c.Agendamentos)
                .HasForeignKey(a => a.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Agendamento>()
                .HasOne(a => a.Barbeiro)
                .WithMany(b => b.Agendamentos)
                .HasForeignKey(a => a.BarbeiroId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
