namespace CinemaWay.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class CinemaWayDbContext : IdentityDbContext<User>
    {
        public CinemaWayDbContext(DbContextOptions<CinemaWayDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
