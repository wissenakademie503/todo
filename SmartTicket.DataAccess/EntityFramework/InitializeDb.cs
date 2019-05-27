using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicket.DataAccess.EntityFramework
{
    public class InitializeDb:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {

              //Database oluştuktan sonra çalışan metod
        }
    }
}
