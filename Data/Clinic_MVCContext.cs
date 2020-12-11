using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clinic_MVC.Models;

namespace Clinic_MVC.Data
{
    public class Clinic_MVCContext : DbContext
    {
        public Clinic_MVCContext (DbContextOptions<Clinic_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Clinic_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Clinic_MVC.Models.Location> Location { get; set; }

        public DbSet<Clinic_MVC.Models.Staff> Staff { get; set; }

        public DbSet<Clinic_MVC.Models.Appointment> Appointment { get; set; }
    }
}
