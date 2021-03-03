using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class MenuContext:DbContext
    {
        public MenuContext():base("Name=MVCConnect")
        {

        }
        public DbSet<Menu> menudetailes { get; set; }
    }
}