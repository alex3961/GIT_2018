using System.Linq;
using ProjectAlex.EntityFramework;
using ProjectAlex.MultiTenancy;

namespace ProjectAlex.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ProjectAlexDbContext _context;

        public DefaultTenantCreator(ProjectAlexDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
