/// <summary>
/// Created by: Natan Monteiro
/// Date: 2024-12-19
/// Description: Manages external authentication provider credentials and associations.
/// Represents an external login provider association for a user.
/// </summary>
 
namespace Livora.Domain.UserModels
{
    public class ExternalLogin
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Provider { get; private set; } // Google, Apple
        public string ProviderUserId { get; private set; }

        public ExternalLogin(Guid userId, string provider, string providerUserId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Provider = provider;
            ProviderUserId = providerUserId;
        }
    }
}
