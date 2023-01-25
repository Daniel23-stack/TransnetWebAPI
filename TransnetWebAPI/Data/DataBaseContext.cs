using Microsoft.EntityFrameworkCore;
using TransnetWebAPI.Models;

namespace TransnetWebAPI.Data;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions options): base(options)
    {
    }  
    public DbSet<AppUser> Users { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Department> Departments { get; set; }
}