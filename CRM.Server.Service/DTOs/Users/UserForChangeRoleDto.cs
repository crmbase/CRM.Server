using CRM.Server.Domain.Enums;

namespace CRM.Server.Service.DTOs.Users;

public class UserForChangeRoleDto
{
    public long Id { get; set; }
    public UserRole Role { get; set; }
}