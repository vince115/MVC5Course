using System;
using System.Data.Entity.Migrations;
using MVC5Course.Models;

namespace MVC5Course.Migrations
{
    internal sealed class StaffConfiguration : DbMigrationsConfiguration<MVC5Course.Models.DBContext>
    {
        public StaffConfiguration()
        {
            AutomaticMigrationsEnabled = true; // 可根據需求設定
            AutomaticMigrationDataLossAllowed = true; // 允許自動遷移即使可能丟失數據
        }

        protected override void Seed(DBContext context)
        {
           
            // 添加 Staff 假資料
            context.Staffs.AddOrUpdate(
                s => s.Name, // 使用 Name 作為判斷是否重複的依據
                new Staff { Name = "John Doe", Position = "Manager", Salary = 50000 },
                new Staff { Name = "Jane Smith", Position = "Developer", Salary = 40000 },
                new Staff { Name = "Michael Brown", Position = "Designer", Salary = 45000 },
                new Staff { Name = "Emily Davis", Position = "Tester", Salary = 35000 },
                new Staff { Name = "Chris Johnson", Position = "HR", Salary = 38000 },
                new Staff { Name = "Sarah Wilson", Position = "Accountant", Salary = 42000 }
            );
        }
    }
}
