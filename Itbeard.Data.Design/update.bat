dotnet ef migrations add InitialCreate -- "Data Source=c:/temp/appdb.db"
dotnet ef database update --connection "Data Source=c:/temp/appdb.db"