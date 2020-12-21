import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home/home.component';
import { HeaderComponent } from './header/header/header.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { UsersComponent } from './users/users/users.component';
import { TasksComponent } from './tasks/tasks/tasks.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { TaskCardComponent } from './shared/components/task-card/task-card.component';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { TaskHistoryComponent } from './tasks/task-history/task-history.component';
import { TaskDetailComponent } from './tasks/task-detail/task-detail.component';
import { TaskHistoryDetailComponent } from './tasks/task-history-detail/task-history-detail.component';
import { UsersEditComponent } from './users/users-edit/users-edit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    UsersComponent,
    TasksComponent,
    TaskCardComponent,
    UserDetailComponent,
    TaskHistoryComponent,
    TaskDetailComponent,
    TaskHistoryDetailComponent,
    UsersEditComponent,
  ],
  imports: [
    BrowserModule,
    NgbModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
