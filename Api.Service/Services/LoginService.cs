using Api.Domain.DTOs;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repo;

        public LoginService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
                return await _repo.FindByLogin(user.Email);
            else
                return null;
        }
    }
}