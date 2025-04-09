using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp.Interfaces
{
    public class DbMigration
    {
        private readonly ILogger _logger;

        public DbMigration(ILogger logger)
        {
            _logger = logger;
        }

        public void Migration()
        {
            _logger.LogInfo("Migration Started " + DateTime.Now);


            // put your code here


            _logger.LogInfo("Migration End "+DateTime.Now);
        }


    }
}
