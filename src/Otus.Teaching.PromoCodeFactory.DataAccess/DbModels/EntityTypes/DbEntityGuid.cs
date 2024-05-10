using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

public class DbEntityGuid : DbEntity<Guid>
{
    protected override bool IsEmpty(Guid id) => Id == Guid.Empty;
}