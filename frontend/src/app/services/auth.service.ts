import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private httpClient: HttpClient) { }

  isAuthenticated(): boolean {
    return !!this.getSessionId();
  }

  login(username: string, password: string) {
    return this.httpClient
      .post(`${environment.apiBaseUrl}/users/login`, {username: username, password: password});
  }

  getSessionId(): string {
    return localStorage.getItem('session_id');
  }
}
