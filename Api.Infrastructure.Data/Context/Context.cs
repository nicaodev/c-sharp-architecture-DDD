using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}