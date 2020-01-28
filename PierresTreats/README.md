# **Pierrs's Sweet and Savoroy Treats**

###### By Trevor Mackin 01/24/2020  

### **Description**

_This is a server side application built in C# using ASP.NET Core Mvc. This project focuses on migrations using the Entity Framework (Core), demonstrating a working knowledge of both Authentication and Authorization using methods available through the framework. A user should be able to view both products, Flavors and Treats, without having to sign in. If you a user wants access to the CRUD funcitonality that will delete, add, or edit products, the user must create an account and then sign in. The application then will provide options to delete, edit and add both new flavors and treats, as well as store the username and password within the database that was created. Lastly, the application also demonstrates a many to many relationship, where multiple treats may belong to one flavor, and vice versa._

#
###  **Setup/Installation Requirements**

1. Open https://ratta2ii.github.io/PierresTreats.Solution
2. Clone repository to local machine (git clone <repoName>)
3. Navagate to the project directory (PierresTreats)
4. $ dotnet restore
5. $ dotnet build 
6. dotnet ef migrations add Initial (Create database and migration)
7. dotnet ef database update
8. $ dotnet run (to run the application in the browser)
9. Go ahead and expore application

#
* C#
* netcoreapp2.2
* ASP.NET Core Mvc
* Razor
* Entity Framework (Core)
* Html
* Css
* Bootstrap

### **License**

Copyright (c) 2019 **Trevor Mackin**

