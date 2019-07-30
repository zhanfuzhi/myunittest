using System.Data.Common;
using Abp.EntityFramework;

namespace myproject.EntityFramework
{
    public class myprojectDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public myprojectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in myprojectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of myprojectDbContext since ABP automatically handles it.
         */
        public myprojectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public myprojectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public myprojectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
