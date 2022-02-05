using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Vacina> Vacina { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {
            modeBuilder.Entity<Vacina>(entity =>
            {
                entity.ToTable("Vacina");
                entity.Property(p => p.Valor).HasPrecision(18, 2);
                entity.HasOne(p => p.Pessoa).WithMany(p => p.Vacina).HasForeignKey(p => p.PessoaId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            });

            base.OnModelCreating((ModelBuilder)modeBuilder);
        }

    }
}
