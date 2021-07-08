using Microsoft.EntityFrameworkCore;

namespace ArticleApp.Models
{
    /// <summary>
    /// DbContext Class
    /// </summary>
    public class ArticleAppDbContext : DbContext

    {
        //EfCore.SqlServer
        //EfCore.InMemory
        //Configuration.ConfigurationManager
        public ArticleAppDbContext()
        {
            //Empty
        }

        public ArticleAppDbContext(DbContextOptions<ArticleAppDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().Property(m => m.Created).HasDefaultValueSql("GetDate()");
        }

        //[!] ArticleApp 관련 모든 테이블 참조 
        public DbSet<Article> Articles { get; set; }

    }
}
