import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/shared/Models/user';

@Component({
  selector: 'app-users-edit',
  templateUrl: './users-edit.component.html',
  styleUrls: ['./users-edit.component.css']
})
export class UsersEditComponent implements OnInit {

  constructor(private userService: UserService, private router: Router) { }

  returnUrl: string = "";
  user: User = {
    id: 0,
    email: "",
    password: "123",
    fullName: "fullName",
    phone: "1234567890"
  }

  ngOnInit(): void {
  }

  handleSubmit() {
    this.userService.addUser(this.user).subscribe(
      (response) => {
        if (response) {
          this.router.navigate([this.returnUrl])
        }
      }
    )
  }
}
