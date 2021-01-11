using Api.Domain.Entities;
using Api.Infrastructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;

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

            /// seeds

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrador",
                    Email = "abc@g.com",
                    CreatAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
                );
        }
    }
}