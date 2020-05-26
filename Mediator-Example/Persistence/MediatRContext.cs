using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator_Example.Persistence
{
    public class MediatRContext : DbContext
    {
        public MediatRContext(DbContextOptions<MediatRContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article { Id = 1, Name = "Mediator Örneği" },
                new Article { Id = 2, Name = "Portal Serisi" },
                new Article { Id = 3, Name = "VueJs Nedir?" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}