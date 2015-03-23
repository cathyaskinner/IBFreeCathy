using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IBFree.Models;

namespace IBFree.Models
{
    public class IBFreeContext : DbContext
    {
        public DbSet<BadFoods> BadFood { get; set; }
    }
}