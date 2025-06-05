import { Component } from '@angular/core';
import { UserService } from '../../Services/user.service';
import { User } from '../../Interfaces/user.interface';
import { FormsModule } from '@angular/forms';
import { NgIf } from '@angular/common';
import { throws } from 'node:assert';

@Component({
  selector: 'app-sign-in',
  imports: [FormsModule, NgIf],
  templateUrl: './sign-in.component.html',
  styleUrl: './sign-in.component.css'
})
export class SignInComponent {
  user: User = { id: 0, name: '', lastName: '', password: '', email: '' }
  error = ""


  constructor(private userS: UserService) { }
  logIn() {
    this.userS.getUser(this.user.email, this.user.password).subscribe({
      next: (data) => {

        if (data) {
          this.user = data
          this.userS.currentUser = data
        }

         else{
          this.error = "User not existent"
          this.user =  { id: 0, name: '', lastName: '', password: '', email: '' }
          this.userS.currentUser= { id: 0, name: '', lastName: '', password: '', email: '' }
        }

      },
      error: (err) => {
        this.error = "User not existent"
      }
    })
  }


}
