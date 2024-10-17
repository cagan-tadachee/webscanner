namespace webScanner.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly webScannerDbContext _context;

        public InitialHostDbBuilder(webScannerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
