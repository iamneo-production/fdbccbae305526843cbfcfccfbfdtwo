using CenterBookingSystem.Models;
using System;
 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CenterBookingSystem.Data{

public class ApplicationDbContext : DbContext
    {
public ApplicationDbContext()
        {
        }  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EventSpace> EventSpaces { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=BookingDB;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
        // Write your ApplicationDbContext here...
    }}