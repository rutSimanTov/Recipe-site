import { Component } from '@angular/core';
import { UserService } from '../../Services/user.service';
import { User } from '../../Interfaces/user.interface';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  imports: [NgIf,FormsModule],
  templateUrl: './sign-up.component.html',
  styleUrl: './sign-up.component.css'
})
export class SignUpComponent {
  user: User = { id: 0, name: '', lastName: '', password: '', email: '' }
  error: string = ''

  constructor(private userS: UserService) { }

  register() {
    this.userS.getUser(this.user.email, this.user.password).subscribe({
      next: (data) => {
        if (!data) {
          this.userS.addUser(this.user).subscribe();
          this.userS.currentUser = this.user;
        }
        else {
          this.userS.currentUser = { id: 0, name: '', lastName: '', password: '', email: '' }
          this.error = "User alredy exist"
          alert(this.error)
        }

      },
      error: (err) => {
        this.error = "Sing up error"
        alert(this.error)
      }
    })

  }
}
