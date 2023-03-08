using Microsoft.AspNetCore.Identity;

namespace EscolaDOTNET.Data.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
