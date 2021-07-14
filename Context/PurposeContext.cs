using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PurposeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurposeProject.Context
{
    public class PurposeContext : IdentityDbContext
    {
        public PurposeContext(DbContextOptions<PurposeContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }

    }
}
