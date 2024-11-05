using LibraryService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.DataAccess
{
    public static class EFInstaller
    {
        public static IServiceCollection AddEFConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var useInMemoryDatabase = configuration.GetSection("Settings").GetValue<bool>("UseInMemoryDatabase");

            services.AddDbContext<LibraryDbContext>(options =>
            {
                if (useInMemoryDatabase)
                    options.UseInMemoryDatabase("Library");
                else
                    options.UseSqlServer(configuration.GetConnectionString("Library"));
            });

            services.AddScoped<ILibraryRepository, LibraryRepository>();
            return services;
        }
    }
}
