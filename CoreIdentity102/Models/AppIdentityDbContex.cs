using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreIdentity102.Models
{
    public class AppIdentityDbContex : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppIdentityDbContex(DbContextOptions<AppIdentityDbContex> options) : base(options)
        {
        }
    }
}
