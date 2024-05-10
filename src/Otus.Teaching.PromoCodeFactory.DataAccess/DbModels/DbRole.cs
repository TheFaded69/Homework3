using System;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbRole : DbEntityGuid
{
    public Guid EmployeeId { get; set; }
    
    public DbEmployee Employee { get; set; }
    
    public string Name { get; set; }

    public string Description { get; set; }
}