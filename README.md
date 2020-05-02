## **PIERRES SWEET & SAVORY TREATS**

###### By Trevor Mackin 01/24/2020  

### **Description**

_This is a server side MVC application built in C# using the ASP.NET Core framework. This project includes migrations using the Entity Framework (Core). This app also demonstrates a working knowledge of both Authentication and Authorization using ASP.NET Identity. A user should be able to view both products, Flavors and Treats, without having to sign in. If you a user wants access to the CRUD functionality in order add, edit, and delete products, the user must create an account and then sign in. After signing in, the user will have the option to add, edit, and delete, both flavors and treats. The application also has functionality to store the entire menu, as well as registered users within the database that was created using Entity Framework migrations. Lastly, the application demonstrates a many to many relationship, where multiple treats may belong to one flavor, and vice versa._

#
###  **Setup/Installation Requirements**

1. Open https://ratta2ii.github.io/PierresTreats.Solution
2. $ git clone <repoName> (Clone repository to local machine)
3. $ cd PierresTreats.Solutions/PierresTreats (Navagate to the project directory PierresTreats)
4. $ dotnet restore
5. Optional: $ dotnet run (Or continue by first hooking up a database)

6. Configure DB connection string (appsettings.json) 
7. $ dotnet ef migrations add Initial (Create database and migration)
8. $ dotnet ef database update
9. $ dotnet run (to run the application in the browser)

#
* C#
* ASP.NET Core Mvc
* netcoreapp2.2
* Entity Framework (Core)
* ASP.NET Identity
* ASP.NET Razor
* HTML
* CSS
* Bootstrap

#
### **License**

MIT License
Copyright (c) 2020 **Trevor Mackin**