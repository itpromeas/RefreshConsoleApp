using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp.Compisition
{
    public class DbMigration
    {
        private readonly Logger _logger;

        public DbMigration(Logger logger)
        {
            _logger = logger;
        }

        public void Mygrate()
        {
            _logger.Log("Migration started...");
        }
    }
}
