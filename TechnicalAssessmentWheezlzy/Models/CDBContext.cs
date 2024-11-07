using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace TechnicalAssessmentWheezlzy.Models
{
    public class CDBContext : DbContext
    {




        public CDBContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships between entities
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Buyer)
                .WithMany()
                .HasForeignKey(c => c.BuyerId);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Quote)
                .WithMany()
                .HasForeignKey(c => c.QuoteId);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Status)
                .WithMany()
                .HasForeignKey(c => c.StatusId);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.StatusDate)
                .WithMany()
                .HasForeignKey(c => c.StatusDateId);
        }
    }

    public class CarInfoService
    {
        

        


    }
}
