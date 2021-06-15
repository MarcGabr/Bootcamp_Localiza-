using System;
using System.Collections.Generic;
using System.Linq;
using curso.api.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configuration
{
    public class DbFactoryDbContext : IDesingTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Curso2;Trusted_Connection=True;MultipleActiveResultSets=true");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}
