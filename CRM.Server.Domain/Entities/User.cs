using CRM.Server.Domain.Entities.Commons;
using CRM.Server.Domain.Enums;

namespace CRM.Server.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public UserRole Role { get; set; }
}
