using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Akton.BLL.User;

namespace Darisanam.DataLayer
{
    public class ApplicationDataContext:DbContext
    {
        public ApplicationDataContext()
            : base("name=darisanamconnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        static ApplicationDataContext()
        {
            Database.SetInitializer<ApplicationDataContext>(null);
        }

        public static ApplicationDataContext Create()
        {
            return new ApplicationDataContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            Database.SetInitializer<ApplicationDataContext>(null);
            //modelBuilder.Configurations.Add(new Configuration.SubscriptionConfiguration());

            //modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<CustomUserRole>().ToTable("UserRole");
            //modelBuilder.Entity<CustomUserClaim>().ToTable("Claim");
            //modelBuilder.Entity<CustomUserLogin>().ToTable("UserLogin");
            //modelBuilder.Entity<CustomRole>().ToTable("Roles");

        }
        public DbSet<User> User { get; set; } 
        //public DbSet<CustomRole> Roles { get; set; }
        //public DbSet<CustomUserRole> UserRole { get; set; }
    }
}
