using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using Api.Infrastructure.Data.Concrete;
using Api.Infrastructure.Data.Context;
using Api.Infrastructure.Data.Repository;
using Api.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Infrastructure.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            //AddTransient = Para cada operação que tiver uma injeção de dependência ele cria uma nova instância.
            //AddScoped = Mesma instância por escopo da aplicação em um CICLO DE VIDA. Entrou no app, cria uma instância que será utilizada por todos os metódos.
            //Se apertar F5, muda, pois mudou o escopo.
            //AddSingleton = Ao start o app no servidor é uma unica instancia, independente se atualizar o aplicação (F5).

            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserLogin>();

            serviceCollection.AddDbContext<ContextDb>(
               options => options.UseSqlServer("Server=localhost;Database=api_DDD;User Id=sa;Password=159753"));
        }
    }
}