using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are calling from DbMigrator class");
        }
    }
}
