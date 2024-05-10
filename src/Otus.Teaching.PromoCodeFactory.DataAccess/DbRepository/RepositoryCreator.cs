using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbContext;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbRepository;

public class RepositoryCreator<TModelType, TKeyType> : IRepositoryCreator<TModelType, TKeyType> where TModelType : DbEntity<TKeyType>
{
    public RepositoryCreator(IDbContextFactory<DataContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    private readonly IDbContextFactory<DataContext> _contextFactory;

    public async Task<EfRepository<TModelType, TKeyType>> CreateRepositoryAsync() => new(await _contextFactory.CreateDbContextAsync());
    
    public EfRepository<TModelType, TKeyType> CreateRepository() => new(_contextFactory.CreateDbContext());
}