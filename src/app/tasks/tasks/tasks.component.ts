import { Component, OnInit } from '@angular/core';
import { TaskService } from 'src/app/core/services/task.service';
import { CompletedTask } from 'src/app/shared/Models/completedTask';
import { PendingTask } from 'src/app/shared/Models/pendingtask';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {

  constructor(private taskService: TaskService) { }

  pendingTasks: PendingTask[];
  completedTasks: CompletedTask[];

  ngOnInit(): void {
    this.taskService.getAllPendingTasks().subscribe(
      (pendingTasks) => {
        this.pendingTasks = pendingTasks;
        console.log(pendingTasks);
      }
    );

    this.taskService.getAllCompletedTasks().subscribe(
      (completedTasks) => {
        this.completedTasks = completedTasks;
        console.log(completedTasks);
      }
    )
  }

}
