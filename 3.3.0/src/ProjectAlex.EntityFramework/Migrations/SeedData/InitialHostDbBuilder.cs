using ProjectAlex.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ProjectAlex.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ProjectAlexDbContext _context;

        public InitialHostDbBuilder(ProjectAlexDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
