using Microsoft.EntityFrameworkCore;

namespace ParkManager.Infrastructure.DbContexts;

public class ParkManagerDbContext : DbContext
{
    public ParkManagerDbContext(DbContextOptions options) : base(options)
    {
    }
    

}
