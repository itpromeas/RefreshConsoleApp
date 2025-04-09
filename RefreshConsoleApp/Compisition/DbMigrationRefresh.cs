using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshConsoleApp.Interfaces;

namespace RefreshConsoleApp.Compisition
{
    public class DbMigrationRefresh
    {
        private readonly Logger _logger;

        public DbMigrationRefresh(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migration started...");
        }
    }
}
