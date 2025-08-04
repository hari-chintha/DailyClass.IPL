# DailyClass.IPL

DailyClass.IPL is a modular .NET solution for managing, importing, and analyzing IPL cricket match data. It uses clean architecture and DDD principles, enabling efficient storage, retrieval, and advanced player/team statistics via API, background jobs, and import tools.

This solution contains:
- DailyClass.IPL.API: ASP.NET Core Web API for IPL data
- DailyClass.IPL.Domain: Domain models and entities
- DailyClass.IPL.Application: Application logic and use cases
- DailyClass.IPL.Infrastructure: Data access and infrastructure
- DailyClass.IPL.Worker: Console app for background jobs
- DailyClass.IPL.Importer: Console app for importing match JSON files

## Getting Started
- Open the solution in Visual Studio Code
- Build the solution using `dotnet build`
- Run individual projects using `dotnet run --project <ProjectPath>`

## Structure
This solution follows clean architecture and DDD principles. Each project has a specific responsibility.
