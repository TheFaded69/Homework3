using System.Threading.Tasks;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbRepository;

public interface IRepositoryCreator<TModelType, TKeyType> where TModelType : DbEntity<TKeyType>
{
    Task<EfRepository<TModelType, TKeyType>> CreateRepositoryAsync();
    EfRepository<TModelType, TKeyType> CreateRepository();
}