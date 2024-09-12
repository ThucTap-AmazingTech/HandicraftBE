using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Handicraft.Service
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories();
            services.AddServices(); // Đăng ký các service tại đây
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddServices(this IServiceCollection services)
        {

        }
    }
}
