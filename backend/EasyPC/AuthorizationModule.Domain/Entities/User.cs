using AuthorizationModule.Domain.Enums;
using Shared.Domain.Common;

namespace AuthorizationModule.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }    
    
    public UserRole Role { get; set; }
    public bool IsActive { get; set; }
    
    public IEnumerable<RefreshToken> RefreshTokens { get; set; }

}