using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using System.Linq.Expressions;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ICompanyService : IServiceBase<CompanyEntity, CompanyCreationDto, CompanyEditDto>
    {
        Task<List<CompanyEntity>> GetByName(Expression<Func<CompanyEntity, bool>> expression);
    }
}
