# TaskManagementSystem
A task management system developed by C# ASP.NET core and Angular


## ASP.NET source code: check TaskManagementMVC branch

### Folder structure:

#### TaskManagement.Core
##### Entities: all domain entities, including User and Tasks
##### RepositoryInterfaces: interfaces that we need for data access through repositories, including CRUD operations
##### ServiceInterfaces: interfaces that Service/Business logic requires

#### TaskManagement.Infrastructure
##### Data: DbContext
##### Migrations: migration file for ORM
##### Repositories: actual implementation of repositories interfaces
##### Services: actual implementation of services interfaces

#### TaskManagement.API (API web application), project reference to <b>Core and Infrastructure</b>
##### Controler: api controller

#### TaskManagement.Web
##### (Not implemented, just for route testing)

## Angular source code: check TaskManagementSPA branch
