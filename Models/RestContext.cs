using Microsoft.EntityFrameworkCore;

namespace Rest.Models
{
    public class RestContext : DbContext
    {
        public RestContext (DbContextOptions<RestContext> options) : base(options){}
        public DbSet<Reviewer> reviewers { get; set; }
    }
}