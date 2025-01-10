using System;
using System.Data.Entity.Migrations;
using MVC5Course.Models;

namespace MVC5Course.Migrations
{
    internal sealed class MovieConfiguration : DbMigrationsConfiguration<MVC5Course.Models.DBContext>
    {
        public MovieConfiguration()
        {
            AutomaticMigrationsEnabled = true; // 可根據需求設定
            AutomaticMigrationDataLossAllowed = true; // 允許自動遷移即使可能丟失數據
           
        }

      
        protected override void Seed(DBContext context)
        {
            // 添加 Movie 種子數據
            context.Movies.AddOrUpdate(
                m => m.Title, // 使用 Title 作為判斷是否重複的依據
                new Movie { Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Price = 9.99m },
                new Movie { Title = "The Dark Knight", ReleaseDate = new DateTime(2008, 7, 18), Genre = "Action", Price = 14.99m },
                new Movie { Title = "Interstellar", ReleaseDate = new DateTime(2014, 11, 7), Genre = "Adventure", Price = 12.99m },
                new Movie { Title = "The Matrix", ReleaseDate = new DateTime(1999, 3, 31), Genre = "Sci-Fi", Price = 8.99m },
                new Movie { Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 24), Genre = "Crime", Price = 15.99m },
                new Movie { Title = "Titanic", ReleaseDate = new DateTime(1997, 12, 19), Genre = "Romance", Price = 10.99m }
            );
          
        }
    }
}
