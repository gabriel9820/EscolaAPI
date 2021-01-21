using EscolaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Professor>()
                .HasData(new List<Professor>() {
                    new Professor { Id = 1, Nome = "Carlos da Silva" },
                    new Professor { Id = 2, Nome = "Paula Souza" },
                    new Professor { Id = 3, Nome = "Simone Santos" }
                });

            modelBuilder.Entity<Aluno>()
                .HasData(new List<Aluno>() {
                    new Aluno { Id = 1, Nome = "Alex Marques", Nascimento = "01/01/2000", ProfessorId = 1 },
                    new Aluno { Id = 2, Nome = "Júlia Pereira", Nascimento = "01/02/2000", ProfessorId = 2 },
                    new Aluno { Id = 3, Nome = "Caio Ferreira", Nascimento = "01/03/2000", ProfessorId = 3 }
                });
        }
    }
}
