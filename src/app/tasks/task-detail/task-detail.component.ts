import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TaskService } from 'src/app/core/services/task.service';
import { PendingTask } from 'src/app/shared/Models/pendingtask';

@Component({
  selector: 'app-task-detail',
  templateUrl: './task-detail.component.html',
  styleUrls: ['./task-detail.component.css']
})
export class TaskDetailComponent implements OnInit {

  constructor(private taskService: TaskService, private route: ActivatedRoute) { }
  taskId: number;
  task: PendingTask;
  ngOnInit(): void {
    this.route.paramMap.subscribe((p) => {
      this.taskId = Number(p.get('id'));
      this.taskService.getPendingTaskById(this.taskId).subscribe((t) => {
        this.task = t;
      })
    })
  }

}
