using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class CandidateDetailContext : DbContext
    {
        public CandidateDetailContext(DbContextOptions<CandidateDetailContext> options)
            : base(options)
        {
        }

        public DbSet<CandidateDetail> CandidateDetail { get; set; }

    }
}
