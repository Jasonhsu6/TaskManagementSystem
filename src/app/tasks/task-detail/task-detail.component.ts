import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TaskService } from 'src/app/core/services/task.service';
import { PendingTask } from 'src/app/shared/Models/pendingtask';
import { CompletedTask } from 'src/app/shared/Models/completedTask';

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
  
  markAsDone(){
    var completed: CompletedTask = {
      "userId": this.task.userId,
      "title": this.task.title,
      "description": this.task.description,
      "dueDate": this.task.dueDate,
      "remarks": this.task.remarks,
      "completed": new Date(),
    }
    var response1 = this.taskService.deletePendingTask(this.task);
    console.log(response1)
    var response2 = this.taskService.addCompletedTask(completed);
    console.log(response2)
  }

}
