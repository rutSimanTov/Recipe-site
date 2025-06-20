import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "../Interfaces/user.interface";

@Injectable({ providedIn: "root" })

export class UserService {
     // url: string =process.env['baseUrl']+ "/User"
    url: string =environment.baseUrl+ "/User"

    currentUser:User={id:0,name:'',lastName:'',password:'',email:''}

    constructor(private httpC: HttpClient) { }

    getUser(email:string,pass:string): Observable<User> {
        return this.httpC.get<User>(`${this.url}/${email}/${pass}`)
    }

    addUser(user: User): Observable<User> {
        return this.httpC.post<User>(this.url, user)
    }
}
