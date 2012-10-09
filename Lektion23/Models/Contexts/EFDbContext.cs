using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lektion23.Models.Entities;

namespace Lektion23.Models.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsCaption> NewsCaptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<News> News { get; set; }
    }
}