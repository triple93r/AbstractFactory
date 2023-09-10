
using AbstractFactoryPatternApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactoryPatternApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Patient> Patients { get; set; }
    }
        
}
