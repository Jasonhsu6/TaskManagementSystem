import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PendingTask } from 'src/app/shared/Models/pendingtask';
import { User } from 'src/app/shared/Models/user';
import { ApiService } from './api.service';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { CompletedTask } from 'src/app/shared/Models/completedTask';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private apiService: ApiService, private http: HttpClient) { }

  getAllUsers(): Observable<User[]> {
    return this.apiService.getAll('user');
  }

  getUserById(id: number): Observable<User> {
    return this.apiService.getOne('user', id);
  }

  addUser(obj: User): Observable<User> {
    return this.apiService.addOne('user', obj);
  }

  updateUser(obj: User): Observable<User> {
    return this.apiService.updateOne('user', obj);
  }

  deleteUser(obj: User): Observable<User> {
    return this.apiService.deleteOne('user', obj);
  }

  getPendingTasksByUser(userId: number): Observable<PendingTask[]> {
    return this.http.get(`${environment.apiUrl}` + 'user/' + userId + '/pending').pipe(
      map((response) => response as any[])
    );
  }
  getCompletedTasksByUser(userId: number): Observable<CompletedTask[]> {
    return this.http.get(`${environment.apiUrl}` + 'user/' + userId + '/completed').pipe(
      map((response) => response as any[])
    );
  }

}
