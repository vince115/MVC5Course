using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History; // 資料遷移必須加入此命名空間

namespace MVC5Course.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection") // 對應 Web.config 中的連接字串名稱
        {
        }

        // 定義 Movies 表
        public DbSet<Movie> Movies { get; set; }

        // 定義 Staffs 表
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 如果需要，可以在這裡添加模型的額外配置，例如表名稱：
            // modelBuilder.Entity<Movie>().ToTable("MoviesTable");
            // modelBuilder.Entity<Staff>().ToTable("StaffTable");
        }
    }
}
