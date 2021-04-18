If you are wondering how to store data in a database on your console, WPF , UWP, Web Application or Xamarin project (YES! entity Framework Core also works on Xamarin as well).This is article will be a great introduction to get started.

Data persistence plays a vital part in almost every application we create, but connecting, writing SQL queries ,store procedures and all this other ceremonies you go through when working with databases can sometimes be cumbersome. Fortunately for us we have people who got really tired of doing things the old traditional way and decided to create Object-relational Mapping (ORM) tools that do the hard work for us. At the time I am writing this article there are many ORM frameworks to choose when working with .NET Core or .NET 5 ,two of the most famous are Entity Framework and Dapper .I will not be talking about which ORM to choose for your project that decision will be based on your preference and your project, However in this Tutorial I will be showing you how to use Entity Framework Core .

First let's list the tools we are going to use in this tutorial :

  - .NET 5

  - Entity Framework Core

    - Entity Framework Core Tools

    - Entity Framework Core Design

    - Entity Framework SQL Server Extension

 - Visual Studio Code (Visual studio is also fine)

 - SQL Server 

## Setting Up the Environment

Getting Started ,First make sure you have .NET 5 installed in your System ,you can download .NET 5 here .

Next lets create a folder where we are going to put all our code in so in your Computer choose your preferred location and add a folder we are going to call this folder anything you want but I will come mine MovieCenter.

Navigate into the folder then open a console of your choice in the folder. Now we have to create a solution file That will group our project ,to do this run the following command :

`dotnet new sln`

now that we have created our solution we need to create a console project (In this example I will be showing you how to use entity Framework with a console application to keep things simple I wont be using any IoC Containers or patterns) nor will I be writing Unit and integration Tests.

To create the project in the Console run the following command :

`dotnet new console -o ./src/MovieCenter.ConsoleApp`

the previous command create a console application in side the children folders of the current directory called ./src/MovieCenter.ConsoleApp and since we have not specified the name of the project the cli tool will use the MovieCenter.ConsoleApp folder name to name the project file.

The next step is to add the project in our solution we do this with the following command :

`dotnet sln add ./src/MovieCenter.ConsoleApp/MovieCenter.ConsoleApp.csproj`

When working with Entity Framework we need to run commands to manage migrations and update our database, normally when working on Visual Studio ,this all done easily from the nugget console, but since .NET is cross platform you will need the EF cli tools to manage your migrations from your console.to get the EF cli tools installed on your machine run the following command :

`dotnet tool install --global dotnet-ef`

to test if you EF tools were installed in your machine run

`dotnet ef`

IF you have properly installed EF you should see the following output

you almost set now we need to install Entity Framework into our our project ,to keep the commands short ,first navigate to the console project folder from the solution folder with the following command:

`cd ./src/MovieCenter.ConsoleApp/`

once you in your console project folder. run the following command to install Entity Framework:

`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

`dotnet add package Microsoft.EntityFrameworkCore.Tools`

`dotnet add package Microsoft.EntityFrameworkCore.Design`

The first command installs the Entity Framework with the SQL Server Extension since we are going to be working with SQL Server. The second command installed EF tools on your project. The last command installs EF Design this is required for your cli tools to work.

finally Restore and build the project with the following commands :

`dotnet restore in the sln folder or the project folder`

`dotnet build in the sln or project folder`

We have successfully setup or environment next we need to start coding .

To understands the ins and outs read this article :[https://www.buymeacoffee.com/nicolasmaluleke/how-store-data-database-using-entityframework-orm](https://www.buymeacoffee.com/nicolasmaluleke/how-store-data-database-using-entityframework-orm)

