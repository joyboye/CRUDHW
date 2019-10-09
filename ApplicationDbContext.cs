using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDHW.Data;

namespace CRUDHW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDHW.Data.Cars> Cars { get; set; }
        public DbSet<CRUDHW.Data.Manufacturers> Manufacturers { get; set; }
    }
}
