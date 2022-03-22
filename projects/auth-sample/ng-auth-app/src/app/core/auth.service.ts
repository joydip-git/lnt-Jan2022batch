import { Injectable } from '@angular/core';

@Injectable()
export class AuthService {

  constructor() { }
  public getToken() {
    return sessionStorage.getItem('token');
  }
  public isLoggedIn() {
    if (sessionStorage.getItem('token'))
      return true;
    else
      return false;
  }
  public logout() {
    sessionStorage.removeItem('token')
  }
}
