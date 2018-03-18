using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SchoolAwesome.Authorization.Roles;
using SchoolAwesome.Authorization.Users;
using SchoolAwesome.MultiTenancy;
using SchoolAwesome.Models;

namespace SchoolAwesome.EntityFrameworkCore
{
    public class SchoolAwesomeDbContext : AbpZeroDbContext<Tenant, Role, User, SchoolAwesomeDbContext>
    {
        /* Define a DbSet for each entity of the application */

        // Begin Idowu's Additions
        public DbSet<School_Class> School_Classes { get; set; }
        public DbSet<School_ClassArm> School_ClassArms { get; set; }
        public DbSet<School_Subject> School_Subjects { get; set; }
        // End Idowu's Additions

        public SchoolAwesomeDbContext(DbContextOptions<SchoolAwesomeDbContext> options)
            : base(options)
        {
        }
    }
}
