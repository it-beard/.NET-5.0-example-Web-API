### This is an example of WebAPI based on .NET Core 5.0
Application has standard three-layer architecture: 
- All business logic moved to Services.
- Controllers as slim as possible and only transfer data between end clients and services.
- Services communicate with DB through Repositories.


###Solution packages
- **Autofac 5.1** used as DI library
- **Automapper 9.0** used as custom models mapping library
- **EF Core 5** - as an ORM and tools for working with DB from the code.
Migration mechanism setup and works through **dotnet-ef tool**

All code was written in JetBrains **Rider** IDE