using JopBoard.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopBoard.Infrastrucue.Data.DbContexts
{
    public class JopDbConrext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Skill> Skills;

        public DbSet<Resume> Resumes;

        public DbSet<Notification> Notifications;

        public DbSet<Job> Jobs;

        public DbSet<Company> Companies;

        public DbSet<Application > Applications;
        public JopDbConrext (DbContextOptions<JopDbConrext> options) : base (options)
        {
            
        }
    }
}
