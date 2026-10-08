using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEf.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
