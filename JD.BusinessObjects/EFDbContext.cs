using JD.BusinessEntity;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace JD.BusinessObjects
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("Data Source=AYAN-PC;Initial Catalog=JD;Integrated Security=True")
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
        public System.Data.Entity.DbSet<UserType> books { get; set; }
        public System.Data.Entity.DbSet<Users> users { get; set; }
        public System.Data.Entity.DbSet<Country> counties { get; set; }
        public System.Data.Entity.DbSet<State> states { get; set; }
        public System.Data.Entity.DbSet<City> cities { get; set; }
        public System.Data.Entity.DbSet<FranchiseType> franchiseTypes { get; set; }
        public System.Data.Entity.DbSet<Franchise> franchises { get; set; }
        public System.Data.Entity.DbSet<FranchiseLocation> franchiseLocations { get; set; }
    }
}
