# ASP.NET Core WebAPI with SQL Server Boilerplate
## Built using Docker-Compose

Note: Requires [Docker](https://www.docker.com/)

Based off of [this](https://docs.docker.com/compose/aspnet-mssql-compose/) with some exceptions, notably;
 - .NET 6
 - Base Application is minimal WebAPI
 - ApplicationDbContext configured to use containerized SqlServer instance

## Usage
From the base directory, you can build the two containers and start them up with the following command:

``` bash
docker-compose up --build
```

[cherm.io](https://cherm.io)


