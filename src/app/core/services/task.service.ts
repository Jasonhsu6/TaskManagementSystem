import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CompletedTask } from 'src/app/shared/Models/completedTask';
import { PendingTask } from 'src/app/shared/Models/pendingtask';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private apiService: ApiService) { }

  getAllPendingTasks(): Observable<PendingTask[]> {
    return this.apiService.getAll('task/pending');
  }

  getPendingTaskById(id: number): Observable<PendingTask> {
    return this.apiService.getOne('task/pending', id);
  }

  addPendingTask(obj: PendingTask): Observable<PendingTask> {
    return this.apiService.addOne('task/pending', obj);
  }

  updatePendingTask(obj: PendingTask): Observable<PendingTask> {
    return this.apiService.updateOne('task/pending', obj);
  }

  deletePendingTask(obj: PendingTask): Observable<PendingTask> {
    return this.apiService.deleteOne('task/pending', obj);
  }

  getAllCompletedTasks(): Observable<CompletedTask[]> {
    return this.apiService.getAll('task/completed');
  }

  getCompletedTaskById(id: number): Observable<CompletedTask> {
    return this.apiService.getOne('task/completed', id);
  }

  addCompletedTask(obj: CompletedTask): Observable<CompletedTask> {
    return this.apiService.addOne('task/completed', obj);
  }

  updateCompletedTask(obj: CompletedTask): Observable<CompletedTask> {
    return this.apiService.updateOne('task/completed', obj);
  }

  deleteCompletedTask(obj: CompletedTask): Observable<CompletedTask> {
    return this.apiService.deleteOne('task/completed', obj);
  }

}
