using GlamCare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GlamCare
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> SkinCareQuestions { get; set; }
        public DbSet<Answer> SkinCareAnswers { get; set; }
        public DbSet<Routine> SkinCareRoutines { get; set; }
        public DbSet<SkinCareStep> SkinCareSteps { get; set; }
    }
}
