﻿using Microsoft.EntityFrameworkCore;

namespace ADSALUNOS2024.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options){ }
        public DbSet<Curso> Cursos { get; set; }
    }
}
