import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/shared/Models/user';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  constructor(private userService: UserService) { }

  users: User[];
  ngOnInit(): void {
    this.userService.getAllUsers().subscribe(
      (users) => {
        console.log(users);
        this.users = users;
      }
    )
  }

}
