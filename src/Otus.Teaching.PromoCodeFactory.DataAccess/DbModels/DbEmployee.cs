using System;
using Otus.Teaching.PromoCodeFactory.DataAccess.DbModels.EntityTypes;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.DbModels;

public class DbEmployee : DbEntityGuid
{
    public Guid PromoCodeId { get; set; }
    
    public DbPromoCode PromoCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public string Email { get; set; }

    public DbRole Role { get; set; }

    public int AppliedPromocodesCount { get; set; }
}