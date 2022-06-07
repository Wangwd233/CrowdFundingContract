using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CrowdFundingContract.Models;

namespace CrowdFundingContract.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CrowdFundingContract.Models.RequestFunds> RequestFunds { get; set; }
        public DbSet<CrowdFundingContract.Models.Funders> Funders { get; set; }
    }
}
