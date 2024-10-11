using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IServiceBase<TEntityBase, TCreationDto, TEditDto> where TEntityBase : EntityBase where TCreationDto : BaseCreationDto where TEditDto : BaseEditDto
    {
        Task<List<TEntityBase>> GetAllAsync();
        Task<TEntityBase> GetByIdAsync(Guid id);
        Task InsertAsync(TCreationDto entity);
        Task UpdateAsync(TEditDto entity, Guid id);
        Task DeleteByIdAsync(Guid id);
    }
}
