using System;
using System.Collections.Generic;
using Microsoft.;

namespace lesson_19_sql_entity_1
{
    public class MyDbContext : DbContext
    {
        protected MyDbContext() : base("DbConnectionString")
        {
            
        }
    }
}