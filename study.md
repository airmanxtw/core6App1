# 2021/11/17
1. 建立webapi專案
   1. dotnet new webapi
2. 安裝EF套件
   1. dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0
   2. dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0
   3. dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0
   4. dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0
3. 將ef指令裝起來 (這個應該只要裝一次就好)
   1. dotnet new tool-manifest
   2. dotnet tool install dotnet-ef
4. 建立資料庫模型
   1. dotnet ef dbcontext scaffold "Data Source=120.117.2.x;Initial Catalog=Evaluate;User ID=airmanx;Password=xxxx" Microsoft.EntityFrameworkCore.SqlServer -o  Models -t Class -t Stud -f

