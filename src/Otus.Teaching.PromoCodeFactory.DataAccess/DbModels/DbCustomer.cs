using System.Collections.Generic;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbCustomer : DbEntityGuid
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public string Email { get; set; }
    
    public List<DbPromoCode> PromoCode { get; set; }
    
    public List<DbCustomerPreference> CustomerPreference { get; set; }
}