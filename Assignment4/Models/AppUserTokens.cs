using Microsoft.AspNetCore.Identity;


namespace Assignment4.Models
{
    public class AppUserTokens : IdentityUserToken<string>
    {
        public DateTime ExpireDate { get; set; }
    }
}
