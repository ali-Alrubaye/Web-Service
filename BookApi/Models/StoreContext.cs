using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookApi.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=BooksEntities")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
          
        //}
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}