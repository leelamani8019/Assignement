using Bookdetials.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookdetials
{
    public class BookContext : DbContext
    {
        public BookContext() { }
        public BookContext(DbContextOptions options) : base(options) { }
        public DbSet<Book> Books { set; get; }
        public DbSet<AddCart> Cart { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAKSHMAN\MSSQLSERVER01;Database=Books;Trusted_Connection=True;");
        }
    }
}