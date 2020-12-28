using Api.Domain.Entities;
using Api.Infrastructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Data.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
    }
}