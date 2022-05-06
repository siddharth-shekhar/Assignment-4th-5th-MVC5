using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AssignmentTwo_ASP.NET_MVC.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("name = DBCS")
        {

        }
        public DbSet<Account> Accounts { get; set; }//to create table in db
    }
}