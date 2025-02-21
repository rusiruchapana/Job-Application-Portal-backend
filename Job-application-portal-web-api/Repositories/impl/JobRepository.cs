using Job_application_portal_web_api.Data;
using Job_application_portal_web_api.Models;

namespace Job_application_portal_web_api.Repositories.impl;

public class JobRepository: IJobRepository
{
    private readonly ApplicationDbContext _context;
    public JobRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Job> CreateJob(Job job)
    {
        await _context.Jobs.AddAsync(job);
        await _context.SaveChangesAsync();
        return job;
    }
}