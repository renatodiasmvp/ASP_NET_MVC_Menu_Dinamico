using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCcomMenuInterativo.Models;

namespace MVCcomMenuInterativo.Models
{
    public class ContextoDados : DbContext
    {
        public ContextoDados() : base("Data Source=.\\SQLEXPRESS;Initial Catalog=BancoMenu;User Id=sa;Password=zaxx34")
        {

        }

        public DbSet<ItemDeMenu> ItensDeMenu { get; set; }
    }
}