using System.Data.Common;
using Abp.Zero.EntityFramework;
using ProjectAlex.Authorization.Roles;
using ProjectAlex.Authorization.Users;
using ProjectAlex.MultiTenancy;

namespace ProjectAlex.EntityFramework
{
    public class ProjectAlexDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ProjectAlexDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ProjectAlexDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ProjectAlexDbContext since ABP automatically handles it.
         */
        public ProjectAlexDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ProjectAlexDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ProjectAlexDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
