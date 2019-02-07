using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApi.Models.latijn.woorden;
namespace WebApi.Models
{
    public class WoordenContext:DbContext
    {
        public DbSet<Woord> Woorden { get; set; }
    }
}