/// <summary>
/// Created by: Natan Monteiro
/// Created at: 2024-01-15
/// Represents a user in the system with authentication and role-based access control.
/// </summary>
namespace Livora.Domain.UserModels
{
    public class UserModel
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string? PasswordHash { get; private set; }
        public UserRole Role { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private UserModel() { }

        public UserModel(string email, UserRole role)
        {
            Id = Guid.NewGuid();
            Email = email;
            Role = role;
            IsActive = true;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetPasswordHash(string hash)
            => PasswordHash = hash;
    }
}