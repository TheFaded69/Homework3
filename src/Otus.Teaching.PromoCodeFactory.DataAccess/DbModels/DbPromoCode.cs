using System;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbPromoCode : DbEntityGuid
{
    public Guid CustomerId { get; set; }
    
    public DbCustomer Customer { get; set; }
    
    public string Code { get; set; }

    public string ServiceInfo { get; set; }

    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public string PartnerName { get; set; }

    public DbEmployee PartnerManager { get; set; }

    public DbPreference Preference { get; set; }
}