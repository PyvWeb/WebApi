using BsWebpub.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BsWebpub
{
    public class WebpubContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory = new LoggerFactory();

        public WebpubContext()
            : base()
        {
            /*var logger = new bus_logging();
            this.Database.Log = s => logger.LogDB("NPGSQL_WebApply", s);*/
        }


        public WebpubContext(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }


        public DbSet<pub_fact> pub_facts { get; set; }
        public DbSet<shr_userd> shr_userds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=sqltest.db.pyv.com.vn;Initial Catalog=webpub;User id=webuser;Password=adminpyvweb;");
            optionsBuilder.UseSqlServer("Server=sqltest.db.pyv.com.vn;Database=webpub;User Id=webuser; Password=adminpyvweb;");

            optionsBuilder.UseLoggerFactory(_loggerFactory);

        }

    }
}

/*
namespace BSWebpub
{
    internal class WebpubContext : DbContext
    {
        public WebpubContext()
            : base("name =webpub")
        {
            Database.SetInitializer<WebpubContext>(null);

            var logger = new BsCommon.bus_logging();
            this.Database.Log = s => logger.LogDB("WebPub", s);
        }*/