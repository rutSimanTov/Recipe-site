import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { UserService } from '../../Services/user.service';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-navbar',
  imports: [RouterLink,NgIf],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

constructor(private userS:UserService){}

isUser():boolean{
  return this.userS.currentUser.name!=""
}
}
