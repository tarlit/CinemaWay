using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CinemaWay.Data.Models;

namespace CinemaWay.Data
{
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
