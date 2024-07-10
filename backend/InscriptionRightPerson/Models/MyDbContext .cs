using InscriptionRightPerson.Resolvers;
using Microsoft.EntityFrameworkCore;

namespace InscriptionRightPerson.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        // Define your DbSet properties for each entity
        public DbSet<Person> People { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Interest_Hobbie> InterestHobbies { get; set; }

      
    }
}