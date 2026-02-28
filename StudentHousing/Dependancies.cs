using StudentHousing.DbContext;
using StudentHousing.Services;

namespace StudentHousing
{
    public static class Dependancies 
    {
        public static IServiceCollection AddDependancies (this IServiceCollection services , IConfiguration configuration )
        {

            services.AddControllers();
            services.AddOpenApi();
            services.AddDbContext(configuration);

            services.AddScoped<IHouseService, HouseService>();

            return services;
        }

        private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionstring));

            return services;
        }
    }
}
