using IdentityCoreProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreProject.Context
{
    public sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
