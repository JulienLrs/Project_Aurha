import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()

export class UserService {

  constructor(private http: HttpClient) { }

  getUser(): Observable<any> {
    return this.http.get<any>('https://localhost:7249/api/UserFeatures/1002');
  }

  getUserBis(): Observable<any> {
    return this.http.get<any>('http://localhost:5230/api/UserFeatures/1002');
  }
}


