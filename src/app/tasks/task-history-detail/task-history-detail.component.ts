import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TaskService } from 'src/app/core/services/task.service';
import { CompletedTask } from 'src/app/shared/Models/completedTask';

@Component({
  selector: 'app-task-history-detail',
  templateUrl: './task-history-detail.component.html',
  styleUrls: ['./task-history-detail.component.css']
})
export class TaskHistoryDetailComponent implements OnInit {

  constructor(private taskService: TaskService, private route: ActivatedRoute) { }
  taskId: number;
  task: CompletedTask;
  ngOnInit(): void {
    this.route.paramMap.subscribe((p) => {
      this.taskId = Number(p.get('id'));
      this.taskService.getCompletedTaskById(this.taskId).subscribe((t) => {
        this.task = t;
      })
    })
  }
}
