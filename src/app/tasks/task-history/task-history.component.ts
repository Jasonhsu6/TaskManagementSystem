import { Component, OnInit } from '@angular/core';
import { TaskService } from 'src/app/core/services/task.service';
import { CompletedTask } from 'src/app/shared/Models/completedTask';

@Component({
  selector: 'app-task-history',
  templateUrl: './task-history.component.html',
  styleUrls: ['./task-history.component.css']
})
export class TaskHistoryComponent implements OnInit {

  constructor(private taskService: TaskService) { }

  completedTasks: CompletedTask[];

  ngOnInit(): void {

    this.taskService.getAllCompletedTasks().subscribe(
      (completedTasks) => {
        this.completedTasks = completedTasks;
        console.log(completedTasks);
      }
    )
  }

}
