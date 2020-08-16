# OnionArchitecture

A simple example of onion architecture in .NET 3.0

##1 - Add layer domain
with Microsoft.EntityFrameworkCore package

##2 - Add layer Repository:

Note
We need to add a migration for our OA_Repository Project, before adding a migration make sure you have added the following packages in the OA_Repository as given below,
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Relational
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Choose OA_Repository Project from Package Manager Console and run > Add-Migration MyInitialMigration which will create a set of tables based on our models.

Next run > Update-Database to apply the migration to the database

##3 - Add layer Service
##4 - Add layer WebApi

