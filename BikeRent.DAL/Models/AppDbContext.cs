using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRent.DAL.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }

        public DbSet<Bike> Bikes { get; set; }
       
    }
}
