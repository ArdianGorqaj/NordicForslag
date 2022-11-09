using Microsoft.EntityFrameworkCore;
using NordicForslag.Models;

namespace NordicForslag.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
    }

    public DbSet<Forslag> Forslags { get; set; }

}
