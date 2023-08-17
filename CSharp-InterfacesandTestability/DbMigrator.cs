using System;
namespace CSharp_InterfacesandTestability
{
	public class DbMigrator
	{
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
		{
			_logger = logger;
		}

		public void Migrate()
		{
			// details of migrating the db
			_logger.LogInfo("Migrating started at {0}" + DateTime.Now);
			_logger.LogInfo("Migrating finished at {0}" + DateTime.Now);

		}
	}
}

