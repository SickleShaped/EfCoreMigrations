using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IServiceBase<TEntityBase, TCreationDto, TEditDto> where TEntityBase : EntityBase where TCreationDto : BaseCreationDto where TEditDto : BaseEditDto
    {
        Task<List<TEntityBase>> GetAllAsync(CancellationToken cancellationToken);
        Task<TEntityBase> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task InsertAsync(TCreationDto entity, CancellationToken cancellationToken);
        Task UpdateAsync(TEditDto entity, Guid id, CancellationToken cancellationToken);
        Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
