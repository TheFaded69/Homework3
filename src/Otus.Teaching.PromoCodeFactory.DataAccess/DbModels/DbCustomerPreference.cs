using System;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbCustomerPreference : DbEntityGuid
{
    public Guid CustomerId { get; set; }

    public DbCustomer Customer { get; set; }
    
    public Guid PreferenceId { get; set; }
    
    public DbPreference Preference { get; set; }
}