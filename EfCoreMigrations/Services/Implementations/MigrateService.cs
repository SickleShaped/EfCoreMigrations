using EfCoreMigrations.DB;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations
{
    public class MigrateService: IMigrateService
    {
        private readonly ApiDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public MigrateService(ApiDbContext dbContext, IConfiguration configuration) {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public void Migrate()
        {
            if(bool.Parse(_configuration["ApplyMigration"]))
            {
                _dbContext.Database.Migrate();
            }
            return;
        }
    }
}
