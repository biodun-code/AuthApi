using AuthApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Data
{
    public class YourDbContext : IdentityDbContext<User>
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
        }

        // Add your custom DbSet and additional configurations here if needed
    }
}
