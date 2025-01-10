# MVC5Course

![專案圖片](https://github.com/vince115/MVC5Course/blob/main/MVC5Course/docs/images/MVC5_Staff_example.jpg "Project Image")

### 資料模型
Models/Movie.cs
Models/Staff.cs
整合至Models/DBContext.cs


### 種子數據
Migrations/
MovieConfiguration.cs
StaffConfiguration.cs



### 添加遷移  擇一指令執行
Add-Migration InitialCreate -ConfigurationTypeName MVC5Course.Migrations.MovieConfiguration
Add-Migration InitialCreate -ConfigurationTypeName MVC5Course.Migrations.StaffConfiguration


會生成
(datetime)_InitialCreate.cs

請先註解掉其他DB //CreateTable(...)   
只讓要生成的DB去運作CreateTable



### 應用遷移  擇一指令執行
Update-Database -ConfigurationTypeName MVC5Course.Migrations.MovieConfiguration -Verbose
Update-Database -ConfigurationTypeName MVC5Course.Migrations.StaffConfiguration -Verbose