# CSharp ASP.NET Rest API Messaging Platform Backend

## A fully-functional Rest API written in C# for a messaging app's backend logic

This project is a Rest API that serves as a backend for any chat app YOU feel like
making. Written with only C#, this program runs fast and gives you complete control
over your data. Not only that, but it also includes and allows you to do all of the
following:

* Create user accounts with passwords hashed securely and stored in an SQLite database
* Request JWTs from server to provide secure authentication when logging in from a client
* Create conversations to connect users with one another
* Send messages between users through conversations
* Manage user and conversation objects: rename and delete as needed
* Swagger UI for testing API functionality
* Fast database access through Microsoft's EntityFrameworkCore
* Asynchronous server calls to allow multiple client requests to be handled simultaneously

## How to compile, run, and publish this project on .NET Core
1. Go to https://dotnet.microsoft.com/en-us/download and download the .NET SDK, or
   run `sudo apt-get install dotnet8` on Linux.
3. Clone this repository.
4. Open a terminal session in your clone of this project and run `dotnet build` to compile
   project assets and download dependencies. 
6. Run `dotnet run` to run this project on a localhost.
7. Run `dotnet publish` to publish this project into a deployable folder/docker container.

See more on the .NET CLI at https://learn.microsoft.com/en-us/dotnet/core/tools/

## How to set up development database
1. Install .NET CLI (Instructions above).
2. Open .NET CLI at this project's root.
3. Install the dotnet-ef tool for running EntityFramework database migrations with
   `dotnet tool install --global dotnet-ef`
4. Update/setup the database with `dotnet ef database update`
> Without making these changes, you will not be able to save any data to the development database
>  while in the development launch configuration.

This API is meant to be simple, so that you can get started with using it right away. 
If you would like to add new features, feel free to fork this repository or submit 
a pull request. 
