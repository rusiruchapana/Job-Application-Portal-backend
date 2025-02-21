using Job_application_portal_web_api.Data;

namespace Job_application_portal_web_api.Repositories.impl;

public class JobRepository: IJobRepository
{
    private readonly ApplicationDbContext _context;
    public JobRepository(ApplicationDbContext context)
    {
        _context = context;
    }
}