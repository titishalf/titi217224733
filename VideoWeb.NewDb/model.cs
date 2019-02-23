using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace VideoWeb.NewDb
{
    public class VideoContext : DbContext
    {
        public DbSet<Videotbl> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.VideoWeb.NewDb;Trusted_Connection=True;");
        }
    }

    public class Videotbl
    {
        [Key]
        public int VideoId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}