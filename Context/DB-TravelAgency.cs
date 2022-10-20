using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using webapp_travel_agency.Models;

public class TravelAgency : DbContext
{
    public DbSet<PacchettoViaggio> Packages { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=travel_agency;Integrated Security=True");
    }
}