import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { TaskDetailComponent } from './tasks/task-detail/task-detail.component';
import { TaskHistoryDetailComponent } from './tasks/task-history-detail/task-history-detail.component';
import { TaskHistoryComponent } from './tasks/task-history/task-history.component';
import { TasksComponent } from './tasks/tasks/tasks.component';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { UsersEditComponent } from './users/users-edit/users-edit.component';
import { UsersComponent } from './users/users/users.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent,
  },
  {
    path: "users",
    component: UsersComponent,
  },
  {
    path: "users/:id",
    component: UserDetailComponent,
  },
  {
    path: "users-edit",
    component: UsersEditComponent,
  },
  {
    path: "tasks",
    component: TasksComponent,
  },
  {
    path: "tasks/:id",
    component: TaskDetailComponent,
  },
  {
    path: "taskhistory",
    component: TaskHistoryComponent,
  },
  {
    path: "taskhistory/:id",
    component: TaskHistoryDetailComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
