using Api.Domain.Entities;
using Api.Domain.Repository;
using Api.Infrastructure.Data.Context;
using Api.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Infrastructure.Data.Concrete
{
    public class UserLogin : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserLogin(ContextDb context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(a => a.Email.Equals(email));
        }
    }
}

