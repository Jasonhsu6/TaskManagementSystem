# TaskManagementSystem
A task management system developed by C# ASP.NET core and Angular


## ASP.NET source code: check TaskManagementMVC branch

### Folder structure:
#### TaskManagement.Core
<ul>
  <li>Entities: all domain entities, including User and Tasks</li>
  <li>RepositoryInterfaces: interfaces that we need for data access through repositories, including CRUD operations</li>
  <li>ServiceInterfaces: interfaces that Service/Business logic requires</li>
 </ul>

#### TaskManagement.Infrastructure
<ul>
  <li>Data: DbContext</li>
  <li>Migrations: migration file for ORM</li>
  <li>Repositories: actual implementation of repositories interfaces</li>
  <li>Services: actual implementation of services interfaces</li>
</ul>

#### TaskManagement.API (API web application), project reference to <strong>Core and Infrastructure</strong>
<ul>
  <li>Controler: api controller</li>
</ul>

#### TaskManagement.Web
(Not implemented, just for route testing)

## Angular source code: check TaskManagementSPA branch

### Folder structure:

#### core/services
<ul>
  <li>API services</li>
  <li>Task service<li>
  <li>User service</li>
</ul>

#### shared
<ul>
  <li>Components: including task-card component, component for displaying task as card</li>
  <li>Models: completedTask, pendingTask, user models</li>
</ul>

### Components:
#### header: header component, layout
#### home: home component, home layout
#### users: including users(list) component and user detail component
#### tasks: including tasks(list) component, task-detail component, task-history(list) component, task-history-detail component 

### App routing:
<ul>
  <li>localhost:4200/</li>
  <li>localhost:4200/users</li>
  <li>localhost:4200/users/:id</li>
  <li>localhost:4200/tasks</li>
  <li>localhost:4200/tasks/:id</li>
  <li>localhost:4200/taskhistory</li>
  <li>localhost:4200/tasks/:id</li>
</ul>
