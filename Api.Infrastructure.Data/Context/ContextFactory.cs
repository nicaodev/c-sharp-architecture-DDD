using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infrastructure.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<ContextDb>
    {
        public ContextDb CreateDbContext(string[] args)
        {
            // Usado para criar as migrações.

            var con = "Server=localhost;Database=api_DDD;User Id=sa;Password=159753";

            var optBuilder = new DbContextOptionsBuilder<ContextDb>();
            optBuilder.UseSqlServer(con);

            return new ContextDb(optBuilder.Options);
        }
    }

}
