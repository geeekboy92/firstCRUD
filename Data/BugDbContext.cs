using firstCRUD.Model;
using Microsoft.EntityFrameworkCore;
namespace firstCRUD.Data;
public class BugDbContext : DbContext
{
    public BugDbContext(DbContextOptions<BugDbContext> options) : base(options)
    {

    }

    public DbSet<Bug> Bugs { get; set; }
}

