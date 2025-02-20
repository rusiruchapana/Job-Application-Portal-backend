using Job_application_portal_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Job_application_portal_web_api.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Job> Jobs { get; set; }
    public DbSet<Application> Applications { get; set; }
    
}