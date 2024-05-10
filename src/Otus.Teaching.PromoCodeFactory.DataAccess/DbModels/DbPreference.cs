using System;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbPreference : DbEntityGuid
{
    public Guid PromoCodeId { get; set; }
    
    public DbPromoCode PromoCode { get; set; }
    
    public Guid CustomerPreferenceId { get; set; }
    
    public DbCustomerPreference CustomerPreference { get; set; }
    
    public string Name { get; set; }
}