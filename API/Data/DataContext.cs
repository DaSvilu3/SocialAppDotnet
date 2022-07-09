using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
// docker run --name some-postgres -p 54320:5432 -e POSTGRES_PASSWORD=mysecretpassword -d postgres
public class DataContext : DbContext 
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<AppUser> Users { get; set; }
}