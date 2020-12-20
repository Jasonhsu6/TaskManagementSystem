import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { CompletedTask } from 'src/app/shared/Models/completedTask';
import { PendingTask } from 'src/app/shared/Models/pendingtask';
import { User } from 'src/app/shared/Models/user';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {

  constructor(private route: ActivatedRoute, private userService: UserService) { }

  userId: number;
  user: User;
  pendingTasks: PendingTask[];
  completedTasks: CompletedTask[];

  ngOnInit(): void {
    this.route.paramMap.subscribe((p) => {
      this.userId = Number(p.get('id'));
      this.userService.getUserById(this.userId).subscribe((u) => {
        this.user = u;
      })
    })

    this.userService.getPendingTasksByUser(this.userId).subscribe((t) => {
      this.pendingTasks = t;
    })
    this.userService.getCompletedTasksByUser(this.userId).subscribe((t) => {
      this.completedTasks = t;
    })
  }

}
