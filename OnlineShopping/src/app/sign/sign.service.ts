import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {User} from './user';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SignService {

  constructor( private _http : HttpClient) { }

  enroll(user: User ) : Observable<User> {
    const headers = new HttpHeaders({'Content-Type':'application/json'});
    const body ={
      username : user.username,
      password : user.password
    };
    return this._http.post<User>('https://localhost:44302/api/login/UserEnroll', body,{headers});
  }
}
  