using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppointmentAPI.Models;

namespace AppointmentAPI.Models
{
    public class AppointmentDetailContext : IdentityDbContext
    {
        public AppointmentDetailContext(DbContextOptions<AppointmentDetailContext> options) : base(options)
        {

        }

        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        

    }
}
